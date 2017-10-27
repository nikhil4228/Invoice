using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InvoiceBLL;
using Invoice.Helper;

namespace Invoice
{
    public partial class frmCustomerReport : MetroForm
    {
        private CustomerRepo _ObjCustomer;
        public static int selectedCustomerId;
        public frmCustomerReport()
        {
            InitializeComponent();
            _ObjCustomer = new CustomerRepo();
        }
        public void loadData()
        {
            try
            {
                dataGridView1.DataSource = _ObjCustomer.getAllCustomers();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void frmCustomerReport_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedCustomerId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Column8"].Value);
            if (e.ColumnIndex == 0)
            {
                using (CustomerInvoice customerInvoice = new CustomerInvoice())
                {
                    customerInvoice.MdiParent = this.MdiParent;
                    customerInvoice.ShowDialog();
                }
                //Details
            }
            else if (e.ColumnIndex == 1)
            {
                //Edit
                using (frmUpdateCustomer updateCustomerForm = new frmUpdateCustomer())
                {
                    updateCustomerForm.MdiParent = this.MdiParent;
                    updateCustomerForm.ShowDialog();
                }
                loadData();
            }
            else if (e.ColumnIndex == 2)
            {
                DialogResult dialouge = MessageBox.Show("Are You Sure you want to DELETE !", "ALERT", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dialouge == DialogResult.Yes)
                {
                    int deletedStatus = _ObjCustomer.deleteCustomer(GlobalVariables.glbUserId,selectedCustomerId);
                    if (deletedStatus > 0)
                    {
                        MessageBox.Show("The Customer is deleted successfully", "Alert", MessageBoxButtons.OK);
                    }
                }
                else if (dialouge == DialogResult.No)
                {

                }
                //Delete
                loadData();
            }
            //MessageBox.Show(e.ColumnIndex.ToString());
        }
    }
}
