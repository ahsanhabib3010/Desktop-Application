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
    public partial class GenerateCustomerReport : Form
    {
        public GenerateCustomerReport()
        {
            InitializeComponent();
        }

        private void GenerateCustomerReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SMSDataSet.CustomerDetails' table. You can move, or remove it, as needed.
            this.CustomerDetailsTableAdapter.Fill(this.SMSDataSet.CustomerDetails);

            this.reportViewer1.RefreshReport();
        }
    }
}
