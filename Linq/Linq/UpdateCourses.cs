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
    public partial class UpdateCourses : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public UpdateCourses()
        {
            InitializeComponent();
        }

        private void UpdateCourses_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var courses = from c in db.Courses.Where(c => c.cid == Convert.ToInt32(textBox1.Text))
                          select c;

            if (courses.Count() > 0)
            {
                Course c = courses.First();

                textBox2.Text = c.ccode;
                textBox3.Text = c.cname;
                textBox4.Text = c.ctotalmarks.ToString();

            }
        
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var courses = from c in db.Courses.Where(c => c.cid == Convert.ToInt32(textBox1.Text))
                          select c;


            Course cu = courses.First();

            cu.ccode = textBox2.Text;
            cu.cname =  textBox3.Text;
            cu.ctotalmarks = Convert.ToInt32(textBox4.Text);
            

            db.SubmitChanges();
            MessageBox.Show("Updated Courses");
        }
    }
}
