using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopByEntity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            get_customers();
        }

        public void get_customers()
        {
            using (SMSEntities db = new SMSEntities())
            {
                dataGridView1.DataSource = db.Customers.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SMSEntities db = new SMSEntities();

            Customer c = new Customer
            {

                cname = textBox1.Text,
                ccontact = textBox2.Text,
                caddress = textBox3.Text,
                cemail = textBox4.Text

            };

            db.Customers.Add(c);
            db.SaveChanges();


            MessageBox.Show("Successfully Added");
            get_customers();
        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (SMSEntities db = new SMSEntities())
            {
                Customer cu = db.Customers.First(c => c.cname == textBox9.Text);

                textBox5.Text = cu.cname;
                textBox6.Text = cu.ccontact;
                textBox7.Text = cu.caddress;
                textBox8.Text = cu.cemail;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SMSEntities db = new SMSEntities())
            {
                Customer cu = db.Customers.First(c => c.cname == textBox9.Text);

                cu.cname = textBox5.Text;
                cu.ccontact = textBox6.Text;
                cu.ccontact = textBox7.Text;
                cu.cemail = textBox8.Text;

                db.SaveChanges();
                MessageBox.Show("Customers Updated");
                get_customers();
            }

            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using(SMSEntities db = new SMSEntities())
            {
                Customer cu = db.Customers.First(c => c.cname == textBox10.Text);


                db.Customers.Remove(cu);
                db.SaveChanges();

                MessageBox.Show("Successfully Deleted");
                get_customers();


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            report r = new report();
            r.Show();
        }
    }
}
