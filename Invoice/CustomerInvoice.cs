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
    public partial class CustomerInvoice : MetroForm
    {
        private InvoiceRepo _ObjInvoice;
        public static int invoiceNo;
        int selectedCustomerId;
        public CustomerInvoice()
        {
            InitializeComponent();
        }

        private void CustomerInvoice_Load(object sender, EventArgs e)
        {
            _ObjInvoice = new InvoiceRepo();
            selectedCustomerId = frmCustomerReport.selectedCustomerId;
            loadData();
        }
        public void loadData()
        {
            try
            {
                dataGridView1.DataSource = _ObjInvoice.GetInVoiceDetailsByCustomerId(selectedCustomerId);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            invoiceNo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value);
            using (frmCompleteDetailsPurchased completedDetails = new frmCompleteDetailsPurchased())
            {
                completedDetails.MdiParent = this.MdiParent;
                completedDetails.ShowDialog();
            }
           // MessageBox.Show(e.ColumnIndex.ToString());
        }
    }
}
