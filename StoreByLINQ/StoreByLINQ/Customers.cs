using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreByLINQ
{
    public partial class Customers : Form
    {
        DataClasses2DataContext db = new DataClasses2DataContext();
        public Customers()
        {
            InitializeComponent();
            get_customer();
        }

        private void Customers_Load(object sender, EventArgs e)
        {

        }

        public void get_customer()
        {
            var customer = from c in db.Customers
                           select c;

            dataGridView1.DataSource = customer;
        }

      

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer c = new Customer{
            
                cname = textBox1.Text,
                ccontact = textBox2.Text,
                caddress = textBox3.Text,
                cemail = textBox4.Text


            };

            db.Customers.InsertOnSubmit(c);
            db.SubmitChanges();
            MessageBox.Show("Successfully Added");
            get_customer();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var customer = from c in db.Customers.Where(c => c.cid == Convert.ToInt32(textBox9.Text))
                          select c;

           if(customer.Count() > 0)
           {
               Customer cu = customer.First();

               textBox5.Text = cu.cname;
               textBox6.Text = cu.ccontact;
               textBox7.Text = cu.caddress;
               textBox8.Text = cu.cemail;

           }
           else{
               MessageBox.Show("Error! Updating Customer");
           }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var customer = from c in db.Customers.Where(c => c.cid == Convert.ToInt32(textBox9.Text))
                           select c;

            if(customer.Count()>0)
            { 
            Customer cu = customer.First();

            cu.cname = textBox5.Text;
            cu.ccontact = textBox6.Text;
            cu.caddress = textBox7.Text;
            cu.cemail = textBox8.Text;
            }
            db.SubmitChanges();
            MessageBox.Show("Successfully Updated Customer");
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var customer = from c in db.Customers.Where(c => c.cid == Convert.ToInt32(textBox10.Text))
                           select c;

            if (customer.Count() > 0)
            {
                DialogResult r = MessageBox.Show("Are you sure to delete", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (r == DialogResult.OK)
                {
                    Customer cu = customer.First(); 
                    db.Customers.DeleteOnSubmit(cu);
                    db.SubmitChanges();
                    MessageBox.Show("Successfully Deleted Customer");
                    get_customer();
                }
                else
                {
                    MessageBox.Show("Error Deleting Customer");
                }
            }


                }

        private void button7_Click(object sender, EventArgs e)
        {
            GenerateCustomerReport gcp = new GenerateCustomerReport();
            gcp.Show();
        }

    }
}
