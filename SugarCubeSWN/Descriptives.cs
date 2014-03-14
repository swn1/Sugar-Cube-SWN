using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarCubeSWN
{
    /// <summary>
    /// Simple statistical accumulator, supports repeated samples, min/max, mean,
    /// variance and standard deviation.  Does not support fork/join (parallel reduce) (yet).
    /// actually, doesn't support variance yet.  add that after minimal functionality.
    /// </summary>
    public class Descriptives
    {
        double m_Min = Double.PositiveInfinity;
        double m_Max = Double.NegativeInfinity;
        double m_Mass = 0;
        double m_Mean = Double.NaN; // provisional mean

        public void AddSample(double xi, int wi = 1)
        {
            if (wi < 1)
                return;
            if (m_Mass == 0)
                m_Mean = xi;
            if (xi < m_Min)
                m_Min = xi;
            if (xi > m_Max)
                m_Max = xi;
            m_Mass += wi;
            // Spicer 1972
            double vj = (xi - m_Mean) * wi / m_Mass;
            m_Mean = m_Mean + vj;
        }

        public double Mass()
        {
            return m_Mass;
        }

        public double Min()
        {
            return m_Min;
        }

        public double Max()
        {
            return m_Max;
        }

        public double Mean()
        {
            return m_Mean;
        }
    }
}
