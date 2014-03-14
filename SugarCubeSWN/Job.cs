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
        internal int m_nCubes;
        int m_nMaxTime;
        public delegate void StatsCallback(Descriptives s);
        StatsCallback m_OnCompletion; // will be called on the worker thread, is that OK?

        internal Descriptives m_summarystats; // note AddSample isn't threadsafe.  collects mean-of-means.
        public System.Random m_RNG; // see http://numerics.mathdotnet.com/docs/Random.html

        public Job(int nAnts, int nCubes, int nMaxTime, StatsCallback dOnCompletion = null)
        {
            // I don't really like Hungarian notation but it's become a habit from sheer repetition.
            m_nAnts = nAnts;
            m_nCubes = nCubes;
            m_nMaxTime = nMaxTime;
            m_OnCompletion = dOnCompletion;

            m_summarystats = new Descriptives();
            m_RNG = new MathNet.Numerics.Random.MersenneTwister(); // clock-based default seed.
        }

        /// <summary>
        /// simulate one ant farm, return true (continue) unless max cube count has been reached
        /// </summary>
        private bool Run1()
        {
            var s = new Descriptives(); // departure time statistics for this cube
            var cube = new Cube(m_nAnts, this);
            for (int t = 0; t < m_nMaxTime; ++t)
            {
                int escaped = cube.Step();
                s.AddSample(t + 1, escaped); // if escaped on step 0, it's at time 1.
                if (cube.Empty)
                    break;
            }

            double completed;
            lock (m_summarystats)
            {
                completed = m_summarystats.Mass();
                if (completed < m_nCubes)
                    m_summarystats.AddSample(s.Mean());
            }

            if (completed+1 == m_nCubes && m_OnCompletion != null)
                m_OnCompletion(m_summarystats);

            return completed+1 < m_nCubes;
        }

        public void Run()
        {
            // non-parallel to start with, enhance after it works
            while (Run1())
                ;
        }

        private void Run(Object state) { Run(); }

        public void Start(int nThreads = 1)
        {
            while (nThreads-- > 0)
                System.Threading.ThreadPool.QueueUserWorkItem(Run);
        }
    }
}
