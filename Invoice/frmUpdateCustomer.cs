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
    public partial class frmUpdateCustomer : MetroForm
    {
        private CustomerRepo _ObjCustomer;
        int selectedCustomerId;
        public frmUpdateCustomer()
        {
            InitializeComponent();
        }
        private void frmUpdateCustomer_Load(object sender, EventArgs e)
        {
            _ObjCustomer = new CustomerRepo();
            selectedCustomerId = frmCustomerReport.selectedCustomerId;
            loadData();
        }

        public void loadData()
        {
            DataTable dtCustomer = new DataTable();
            try
            {
                dtCustomer = _ObjCustomer.getCustomerById(selectedCustomerId);
                txtName.Text = dtCustomer.Rows[0]["Name"].ToString();
                txtAddress.Text = dtCustomer.Rows[0]["Address"].ToString();
                txtMobile.Text = dtCustomer.Rows[0]["Mobile"].ToString();
                txtEmail.Text = dtCustomer.Rows[0]["Email"].ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnUpdate_record_Click(object sender, EventArgs e)
        {
            int status = 0;
            string name = txtName.Text;
            string address = txtAddress.Text;
            long mobile = Convert.ToInt64(txtMobile.Text);
            string email = txtEmail.Text;
            status = _ObjCustomer.updateCustomer(name, mobile, address, email, GlobalVariables.glbUserId, selectedCustomerId);
            if (status >0)
            {
                MessageBox.Show("Customer Details Updated Successfully");
            }
            this.Close();
        }
    }
}
