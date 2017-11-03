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

namespace Invoice
{
    public partial class frmOrders : MetroForm
    {
        private OrdersRepo _objOrders;
        private UserRepo _objUsers;
        public static int selectedInvoiceId;
        public frmOrders()
        {
            InitializeComponent();
            _objOrders = new OrdersRepo();
            _objUsers = new UserRepo();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            DataTable dtOrders = new DataTable();
            dtOrders = _objOrders.getAllOrders();
            if (dtOrders != null && dtOrders.Rows.Count > 0)
            {
                ordersDataGridView.DataSource = dtOrders;
            }
            

            DataTable dtUsers = new DataTable();
            dtUsers = _objUsers.GetAllUsers();
            DataRow dr = dtUsers.NewRow();
            dr["Name"] = "Select User";
            dr["UserId"] = 0;
            dtUsers.Rows.InsertAt(dr, 0);
            cmbUser.DataSource = dtUsers;
            cmbUser.ValueMember = "UserId";
            cmbUser.DisplayMember = "Name";
        }

        private void ordersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            selectedInvoiceId = Convert.ToInt32(ordersDataGridView.Rows[e.RowIndex].Cells["InvoiceNo"].Value.ToString());
            MessageBox.Show(e.RowIndex.ToString() + "ROW clicked" + e.ColumnIndex.ToString() + "Column clicked" + "x" + selectedInvoiceId);
            try
            {
                if (true)
                {

                }
                using (frmOrderDetails orderDetailsForm = new frmOrderDetails())
                {
                    orderDetailsForm.MdiParent = this.MdiParent;
                    orderDetailsForm.ShowDialog();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int invoiceId = 0;
            long customerMobileNo = 0;
            int userId = 0;
            string paymentMode = string.Empty;
            string invoiceDate = string.Empty;
            if (txtBxInvoiceId.Text != string.Empty)
            {
                invoiceId = Convert.ToInt32(txtBxInvoiceId.Text);
            }
            if (txtBxCustomerPhNo.Text != string.Empty)
            {
                customerMobileNo = Convert.ToInt64(txtBxCustomerPhNo.Text);
            }
            if (Convert.ToInt32(cmbUser.SelectedValue) > 0)
            {
                userId = Convert.ToInt32(cmbUser.SelectedValue);
            }
            if (cmbPaymentMode.SelectedIndex > 0)
            {
                paymentMode = cmbPaymentMode.SelectedText;
            }
            if (invoiceDateTimePicker.Text != System.DateTime.Now.ToShortDateString())
            {
                invoiceDate = invoiceDateTimePicker.Text;
            }
            loadFilteredData(invoiceId, userId, customerMobileNo, invoiceDate, paymentMode);
        }

        public void loadFilteredData(int invoiceId,int userId, long customerMobileNo, string invoiceDate, string paymentMode)
        {
            //write method to cal data using filters
            try
            {
                DataTable dtOrders = new DataTable();
                dtOrders = _objOrders.getAllOrdersByFilters(invoiceId, userId, paymentMode, invoiceDate, customerMobileNo);
                if (dtOrders!=null && dtOrders.Rows.Count>0)
                {
                    ordersDataGridView.DataSource = dtOrders;
                }                         
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
