using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SugarCubeSWN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartButton.Enabled = true;
            StopButton.Enabled = false;
            nCubesBox.Text = "10";
            nAntsBox.Text = "100000";
            nMaxTimeBox.Text = "200";
            nThreadsBox.Text = "2";
        }

        private void ReportStats(Descriptives s)
        {
            lock (s)
            {
                AverageField.Text = s.Mean().ToString();
                StdDevField.Text = s.StdDev().ToString();
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // this should use some kind of data binding but the setup isn't obvious and this works...
            int nAnts = Int32.Parse(nAntsBox.Text);
            int nCubes = Int32.Parse(nCubesBox.Text);
            int nMaxTime = Int32.Parse(nMaxTimeBox.Text);
            // TODO: input validation and error reporting

            m_runningjob = new Job(nAnts, nCubes, nMaxTime);
            ProgressField.Text = "0";
            AverageField.Text = "";
            StdDevField.Text = "";
            StartButton.Enabled = false;
            // StopButton.Enabled = true; Stop not yet implemented so don't enable yet.

            timer1.Start();
            m_runningjob.Start();
        }

        private Job m_runningjob;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (m_runningjob != null)
            {
                ReportStats(m_runningjob.m_summarystats);
                double nDone = m_runningjob.m_summarystats.Mass(); // atomic internally
                if (nDone < m_runningjob.m_nCubes)
                {
                    ProgressField.Text = nDone.ToString();
                }
                else
                {
                    ProgressField.Text = "complete";
                    m_runningjob = null;
                    StartButton.Enabled = true;
                    StopButton.Enabled = false;
                    timer1.Stop();
                }
            }
        }
    }
}
