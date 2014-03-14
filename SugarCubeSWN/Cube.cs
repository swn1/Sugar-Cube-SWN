using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarCubeSWN
{
    /// <summary>
    /// represents an instance of the Markov process model derived from the original problem
    /// in the design notes text file, attached as a solution item.
    /// </summary>
    public class Cube
    {
        int[] m_node = { 0, 0, 0 }; // see design notes, index = rank number, val = ant population.
        Job m_job;

        public Cube(int nAnts, Job job)
        {
            m_job = job;
            m_node[0] = nAnts;
        }

        /// <summary>
        /// returns the number of ants reaching the goal on this step
        /// </summary>
        public int Step()
        {
            // something much fancier would be needed to generalize this for an arbitrary
            // stochastic flow graph but for this problem I'm just going to hardwire the flow.
            // compute new values from old, then update old, keep it simple.

            // the chosen RNG wrapper requires n positive, guard the calls.
            int rank0 = 0;
            if (m_node[1] > 0)
                rank0 = MathNet.Numerics.Distributions.Binomial.Sample(m_job.m_RNG, 1.0 / 3, m_node[1]);
            int rank3 = 0;
            if (m_node[2] > 0)
                rank3 = MathNet.Numerics.Distributions.Binomial.Sample(m_job.m_RNG, 1.0 / 3, m_node[2]);

            // directional flow between ranks 1 and 2 is the complement of the flows to 0 and 3.
            int rank1 = m_node[0] + m_node[2] - rank3;
            int rank2 = m_node[1] - rank0;

            m_node[0] = rank0;
            m_node[1] = rank1;
            m_node[2] = rank2;
            // no need to record the population of the terminal node

            return rank3;
        }

        public bool Empty { get { return m_node[0] + m_node[1] + m_node[2] == 0; } }
    }
}
