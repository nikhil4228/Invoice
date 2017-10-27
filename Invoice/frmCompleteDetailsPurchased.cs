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
    public partial class frmCompleteDetailsPurchased : MetroForm
    {
        private InvoiceRepo _ObjInvoice;
        int invoiceNumber;
        public frmCompleteDetailsPurchased()
        {
            InitializeComponent();
        }

        private void frmCompleteDetailsPurchased_Load(object sender, EventArgs e)
        {
            _ObjInvoice = new InvoiceRepo();
            invoiceNumber = CustomerInvoice.invoiceNo;
            loadData();
        }
        public void loadData()
        {
            try
            {
                dataGridView1.DataSource = _ObjInvoice.GetCompleteDetailsPurchased(invoiceNumber);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
