using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCourses adc = new AddCourses();
            adc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewCourses vc = new ViewCourses();
            vc.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateCourses uc = new UpdateCourses();
            uc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteCourses dc = new DeleteCourses();

            dc.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Marksheet mk = new Marksheet();
            mk.Show();
        }
    }
}
