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

        }
    }
}
