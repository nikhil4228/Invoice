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
            MessageBox.Show(e.RowIndex.ToString()+"ROW clicked"+e.ColumnIndex.ToString()+"Column clicked");
        }
    }
}
