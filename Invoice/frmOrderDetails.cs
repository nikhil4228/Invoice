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
    public partial class frmOrderDetails : MetroForm
    {
        private OrdersRepo _objOrders;
        public int invoiceNo = frmOrders.selectedInvoiceId;
        public frmOrderDetails()
        {
            InitializeComponent();
            _objOrders = new OrdersRepo();
        }
        public void loadData()
        {
            try
            {
                DataTable dtOrderDetails = new DataTable();
                dtOrderDetails = _objOrders.getOrderDetails(invoiceNo);
                if (dtOrderDetails!=null && dtOrderDetails.Rows.Count>0)
                {
                    dataGridView1.DataSource = dtOrderDetails;
                    lblTotalValue.Text = dtOrderDetails.Rows[0]["TotalPrice"].ToString();
                }                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
