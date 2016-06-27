using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrenningApp.Manager;

namespace TrenningApp
{
    public partial class TrainingApp : Form
    {
        public TrainingApp()
        {
            InitializeComponent();
        }

        private void btnGetCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerManager manager = new CustomerManager();
                var customers = manager.GetCustomers(ConnectionParams.ConnectionString);
                txtCustomerList.Text += customers.Select(s => s.ToString()).Aggregate((a, b) => a.ToString() + Environment.NewLine + b.ToString());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
