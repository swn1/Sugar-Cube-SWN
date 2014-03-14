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
            nCubesBox.Text = "1000";
            nAntsBox.Text = "1000000";
            nMaxTimeBox.Text = "1000";
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // this should use some kind of data binding but the setup isn't obvious and this works...
            int nAnts = Int32.Parse(nAntsBox.Text);
            int nCubes = Int32.Parse(nCubesBox.Text);
            int nMaxTime = Int32.Parse(nMaxTimeBox.Text);
            // TODO: input validation and error reporting

            System.Action OnCompletion = () =>
            {
                StartButton.Enabled = true;
                StopButton.Enabled = false;
            };
            var myJob = new Job(nAnts, nCubes, nMaxTime, OnCompletion);
            StartButton.Enabled = false;
            // StopButton.Enabled = true; Stop not yet implemented so don't enable yet.
            
            // TODO: pass job to worker thread ...
            myJob.Run();
        }
    }
}
