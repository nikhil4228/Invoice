using Invoice.Helper;
using InvoiceBLL;
using MessageBoxExample;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice
{
    public partial class frmStocks : MetroForm
    {
        private ErrorLogs _errorLogs;
        private ProductRepo _repoProduct;
        private StockRepo _repoStock;
        public frmStocks()
        {
            _errorLogs = new ErrorLogs();
            _repoProduct = new ProductRepo();
            _repoStock = new StockRepo();
            InitializeComponent();
        }

        private void frmStocks_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtProducts = _repoProduct.GetAllProducts();
                DataRow dr = dtProducts.NewRow();
                dr["ProductId"] = 0;
                dr["Name"] = "--Select Product--";
                dtProducts.Rows.InsertAt(dr, 0);
                cmbProducts.DisplayMember = "Name";
                cmbProducts.ValueMember = "ProductId";
                cmbProducts.DataSource = dtProducts;
                dtpStockDate.MaxDate = DateTime.Now;
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmStocks", "frmStocks_Load", ex.Message);
            }
        }

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbProducts.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    Int64 intProductId = Convert.ToInt64(cmbProducts.SelectedValue.ToString());
                    txtQty.Text = "";
                    lblCount.Text = "(" + _repoStock.getProductStockCount(intProductId).ToString() + ")";
                    lblNotification.Text = "";
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmStocks", "cmbProducts_SelectedIndexChanged", ex.Message);
            }
        }

        private void txtQty_KeyUp(object sender, KeyEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtQty.Text, "^[0-9]*$"))
            {
                txtQty.Text = string.Empty;
                e.Handled = true;
                return;
            }
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure want to Update the Stock?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr.ToString() == "Yes")
                {
                    if (cmbProducts.SelectedValue.ToString() != "System.Data.DataRowView")
                    {
                        if (txtQty.Text == string.Empty)
                        {
                            MyMessageBox.ShowBox("Invalid Qty?", "Alert!");
                            txtQty.Focus();
                        }

                        Int64 intProductId = Convert.ToInt64(cmbProducts.SelectedValue.ToString());
                        string strFeature = txtFeatures.Text;
                        int Qty = Convert.ToInt32(txtQty.Text);
                        string dtStockDate = DateTime.Now.ToShortDateString();
                        if (dtpStockDate.Text != string.Empty)
                        {
                            dtStockDate = dtpStockDate.Text;
                        }
                        int CreatedBy = Convert.ToInt32(GlobalVariables.glbUserId);
                        int isInsrtedorUpdated = _repoStock.UpdateInsertStock(intProductId, strFeature, Qty, dtStockDate, CreatedBy);
                        if (isInsrtedorUpdated > 0)
                        {
                            lblNotification.Text = "Stock Updated Successfully!";
                            txtFeatures.Clear();
                            txtQty.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmStocks", "btnUpdateStock_Click", ex.Message);
            }
        }

    }
}
