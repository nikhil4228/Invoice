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
    public partial class StockDetails : MetroForm
    {
        int productId = Stocks.selectedProductId;
        private StockRepo _objStock;
        public StockDetails()
        {
            InitializeComponent();
            _objStock = new StockRepo();
        }

        private void StockDetails_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtStockDetails = _objStock.getStockDetails(productId);
                if (dtStockDetails != null)
                {
                    dataGridView1.DataSource = dtStockDetails;
                    lblStockPrdocutName.Visible = true;
                    //lblTotalQuantity.Visible = true;
                   // lblTotalQuantity.Text = Convert.ToString(dtStockDetails.Rows[0]["quantity"]);
                    lblStockPrdocutName.Text= Convert.ToString(dtStockDetails.Rows[0]["Name"])+" - " + Convert.ToString(dtStockDetails.Rows[0]["quantity"]);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
