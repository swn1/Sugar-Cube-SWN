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
    internal class Job
    {
        int m_nAnts;
        int m_nCubes;
        int m_nMaxTime;
        System.Action m_OnCompletion; // will be called on the worker thread, is that OK?
        public Job(int nAnts, int nCubes, int nMaxTime, System.Action dOnCompletion)
        {
            // I don't really like Hungarian notation but it's become a habit from sheer repetition.
            m_nAnts = nAnts;
            m_nCubes = nCubes;
            m_nMaxTime = nMaxTime;
            m_OnCompletion = dOnCompletion;
        }

        public void Run()
        {
            // do stuff
            m_OnCompletion();
        }
    }
}
