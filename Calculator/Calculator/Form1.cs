using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals("") && !textBox2.Text.Equals(""))
            {
                if(radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
                {
                    if (radioButton1.Checked) 
                    { 
                    int add = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
                    label1.Text = "Result = " + add;
                    }
                    if (radioButton2.Checked)
                    {
                        int add = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text);
                        label1.Text = "Result = " + add;
                    }
                    if (radioButton3.Checked)
                    {
                        int add = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text);
                        label1.Text = "Result = " + add;
                    }
                    if (radioButton4.Checked)
                    {
                        int add = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
                        label1.Text = "Result = " + add;
                    }
                }
                else{
                    MessageBox.Show("Select your Choice");
                }
            }
            else
            {
                MessageBox.Show("Enter any number");
            }
        }
    }
}
