using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarCubeSWN
{
    /// <summary>
    /// A job represents the work to be done when the user presses Start, it could also
    /// represent a command line or RPC invocation if the program were extended.
    /// </summary>
    public class Job
    {
        int m_nAnts;
        int m_nCubes;
        int m_nMaxTime;
        System.Action m_OnCompletion; // will be called on the worker thread, is that OK?

        Descriptives m_summarystats; // note AddSample isn't threadsafe.  collects mean-of-means.
        public System.Random m_RNG; // see http://numerics.mathdotnet.com/docs/Random.html

        public Job(int nAnts, int nCubes, int nMaxTime, System.Action dOnCompletion)
        {
            // I don't really like Hungarian notation but it's become a habit from sheer repetition.
            m_nAnts = nAnts;
            m_nCubes = nCubes;
            m_nMaxTime = nMaxTime;
            m_OnCompletion = dOnCompletion;

            m_summarystats = new Descriptives();
            m_RNG = new MathNet.Numerics.Random.MersenneTwister(); // clock-based default seed.
        }

        public void Run()
        {
            // non-parallel to start with, enhance after it works
            for (int c = 0; c < m_nCubes; ++c)
            {
                var s = new Descriptives(); // departure time statistics for this cube
                var cube = new Cube(m_nAnts, this);
                for (int t = 0; t < m_nMaxTime; ++t)
                {
                    int escaped = cube.Step();
                    s.AddSample(t, escaped);
                    if (cube.Empty)
                        break;
                }

                // TODO: interlock when parallelized
                m_summarystats.AddSample(s.Mean());
            }

            if (m_OnCompletion != null)
                m_OnCompletion();
        }
    }
}
