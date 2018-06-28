using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals("") && !textBox2.Text.Equals(""))
            {
                if (radioButton1.Checked && radioButton3.Checked)
                {
                    double bmi = Convert.ToDouble(textBox1.Text) / (Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox2.Text) * 703 );
                    label3.Text = "BMI = " + bmi;
                }

                if (radioButton2.Checked && radioButton4.Checked)
                {
                    double bmi = Convert.ToDouble(textBox1.Text) / (Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox2.Text));
                    label3.Text = "BMI = " + bmi;

                }
            }
            else
            {
                MessageBox.Show("Please! Enter Information");
            }
        }
    }
}
