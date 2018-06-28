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
    public partial class Marksheet : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Marksheet()
        {
            InitializeComponent();
            get_students();
        }

        public void get_students()
        {
            var std = from s in db.Students 
                      select s.sname;

            comboBox1.DataSource = std;


        }
        private void Marksheet_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var marksheet = from s in db.Students.Where(s => s.sid == Convert.ToInt32(textBox1.Text))
                            join er in db.Enrollments on s.sid equals er.sid
                            join c in db.Courses on er.cid equals c.cid
                            select new
                            {
                                ccode = c.ccode,
                                cname = c.cname,
                                cmarks = c.ctotalmarks,
                                obtainedmarks = er.obtainedmarks

                            };
        
        
            dataGridView1.DataSource = marksheet;
        }
    }
}
