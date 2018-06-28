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
    public partial class AddCourses : Form
    {
        public AddCourses()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            DataClasses1DataContext db = new DataClasses1DataContext();

            Course c = new Course { 
            
                ccode = textBox1.Text,
                cname = textBox2.Text,
                ctotalmarks = Convert.ToInt32(textBox3.Text)   
            };

            db.Courses.InsertOnSubmit(c);
            db.SubmitChanges();
            MessageBox.Show("Successfully Added");
        }
    }
}
