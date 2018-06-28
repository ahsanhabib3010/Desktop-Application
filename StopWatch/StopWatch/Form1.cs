using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        int seconds = 0, minutes = 0, hours=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            hours = minutes = seconds = 0;
            label3.Text = "00";
            label2.Text = "00";
            label1.Text = "00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds > 59)
            {
                minutes++;
                seconds = 0;
            }

            if (minutes > 59)
            {
                hours++;
                minutes = 0;
            }

            if (hours > 23)
            {
                hours = 0;
            }

            label3.Text = seconds.ToString();
            label2.Text = minutes.ToString();
            label1.Text = hours.ToString();
        }
    }
}
