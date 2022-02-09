using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlotterDemo
{
    public partial class Form1 : Form
    {
        public Form1 ()
        {
            InitializeComponent ();

            timer.Interval = 30;
            timer.Tick += new EventHandler (timer_Tick);
            timer.Start ();
        }

        Timer timer = new Timer ();

        void timer_Tick (object sender, EventArgs e)
        {
            this.runningGraph1.Add (this.trackBar1.Value);
        }

        private void StartStopButton_Click (object sender, EventArgs e)
        {
            this.timer.Enabled = !this.timer.Enabled;
        }
    }
}