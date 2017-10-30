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
        public static int selectedInvoiceId;
        public frmOrders()
        {
            InitializeComponent();
            _objOrders = new OrdersRepo();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            DataTable dtOrders = new DataTable();
            dtOrders = _objOrders.getAllOrders();
            ordersDataGridView.DataSource = dtOrders;
        }

        private void ordersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            selectedInvoiceId = Convert.ToInt32(ordersDataGridView.Rows[e.RowIndex].Cells["InvoiceNo"].Value.ToString());
            MessageBox.Show(e.RowIndex.ToString() + "ROW clicked" + e.ColumnIndex.ToString() + "Column clicked"+"x"+selectedInvoiceId);
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
            long PhoneNumber = 0;
            string invoiceDate = invoiceDateTimePicker.Text;
            string paymentMode = string.Empty;
            if (txtBxInvoiceId.Text != string.Empty)
            {
                invoiceId = Convert.ToInt32(txtBxInvoiceId.Text);
            }
            if (txtBxCustomerPhNo.Text != string.Empty)
            {
                PhoneNumber = Convert.ToInt64(txtBxCustomerPhNo.Text);
            }
            if (radioBtnCard.Checked)
            {               
                paymentMode = "Card";
            }
            else if (radioBtnCash.Checked)
            {
                paymentMode = "Cash";
            }
        }

        public void loadFilteredData(int invoiceId ,long PhoneNumber , string invoiceDate,string paymentMode)
        {
            //write method to cal data using filters
        }
    }
}
