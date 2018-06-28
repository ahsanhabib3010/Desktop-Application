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
    public partial class ViewCourses : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public ViewCourses()
        {
            InitializeComponent();
            get_courses();
        }

        public void get_courses()
        {
            var courses = from c in db.Courses
                          select c;

            dataGridView1.DataSource = courses;

        }
        private void ViewCourses_Load(object sender, EventArgs e)
        {

        }
    }
}
