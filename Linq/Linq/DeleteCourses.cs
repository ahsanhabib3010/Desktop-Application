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
    public partial class DeleteCourses : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public DeleteCourses()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var courses = from c in db.Courses.Where(c => c.cid == Convert.ToInt32(textBox1.Text))
                          select c;

           

            if (courses.Count() > 0)
            {
                DialogResult d = MessageBox.Show("Are you sure you want to delete","Delet Confirmation" , MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (d == DialogResult.OK)
                {
                    Course c = courses.First();
                    db.Courses.DeleteOnSubmit(c);
                    db.SubmitChanges();
                    MessageBox.Show("Delete Confirmed.");
                }
                else
                {
                    MessageBox.Show(" Nahi hua ");
                }
            
            }
                          

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
