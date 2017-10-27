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
using MessageBoxExample;
using Invoice.Helper;
using InvoiceBLL.Model;
using System.Text.RegularExpressions;

namespace Invoice
{
    public partial class frmInvoice : MetroForm
    {
        int indexRow;
        Bitmap bmp;
        private ErrorLogs _errorLogs;
        private ProductRepo _repoProduct;
        private InvoiceRepo _repoInvoice;
        private StockRepo _repoStock;
        private InvoiceViewModel _vmInvoice;
        public frmInvoice()
        {
            _errorLogs = new ErrorLogs();
            _repoProduct = new ProductRepo();
            _repoInvoice = new InvoiceRepo();
            _repoStock = new StockRepo();
            _vmInvoice = new InvoiceViewModel();
            InitializeComponent();
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtProducts = _repoProduct.GetAllProducts();
                dtpInvoiceDate.MaxDate = DateTime.Now; //Minimum Date is today
                //dtpInvoiceDate.MinDate = DateTime.Now.AddMonths(1); //Maximum Date is 1 month from today
                Int64 InvoiceNo = _repoInvoice.getInvoiceIdentity() + 1;
                txtInvoiceNo.Text = InvoiceNo.ToString();
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                foreach (DataRow row in dtProducts.Rows)
                {
                    MyCollection.Add(row["Name"].ToString() + "|" + row["ProductId"].ToString());
                }
                //AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                //data.Add("Mahesh Chand");
                //data.Add("Mac Jocky");
                //data.Add("Millan Peter");
                txtProductName.AutoCompleteCustomSource = MyCollection;
                GridStructure();
                dataGridView1.Height = 400;
                txtProductName.Focus();
                cmbCashCard.SelectedIndex = cmbCashCard.FindStringExact("Cash");
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmInvoice", "frmInvoice_Load", ex.Message);
            }
            finally
            {

            }
        }

        private void GridStructure()
        {
            try
            {
                DataGridViewColumn column = dataGridView1.Columns["ProductID"];
                column.Width = 50;
                DataGridViewColumn column1 = dataGridView1.Columns["ProductName"];
                column1.Width = 250;
                DataGridViewColumn column2 = dataGridView1.Columns["OriginalPrice"];
                column2.Width = 90;
                DataGridViewColumn column3 = dataGridView1.Columns["Discount"];
                column3.Width = 90;
                DataGridViewColumn column4 = dataGridView1.Columns["CGST"];
                column4.Width = 60;
                DataGridViewColumn column5 = dataGridView1.Columns["SGST"];
                column5.Width = 60;
                DataGridViewColumn column6 = dataGridView1.Columns["Price"];
                column6.Width = 90;
                DataGridViewColumn column7 = dataGridView1.Columns["Qty"];
                column7.Width = 50;
                DataGridViewColumn column8 = dataGridView1.Columns["TotalAmount"];
                column8.Width = 90;
                DataGridViewColumn column9 = dataGridView1.Columns["aqty"];
                column9.Width = 0;
                DataGridViewColumn column10 = dataGridView1.Columns["Action"];
                column10.Width = 60;
                DataGridViewColumn column11 = dataGridView1.Columns["Edit"];
                column11.Width = 25;
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmInvoice", "GridStructure", ex.Message);
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAvailableQty.Text == "0" || txtAvailableQty.Text == string.Empty)
                {
                    MyMessageBox.ShowBox("No Stocks available for the selected Product!", "Alert!");
                    return;
                }

                if (txtProductName.Text == string.Empty && !txtProductName.Text.Contains("|"))
                {
                    MyMessageBox.ShowBox("Invalid product choosen?", "Alert!");
                }
                if (txtSaleQty.Text == string.Empty || txtPrice.Text == string.Empty || txtSaleQty.Text == "0")
                {
                    MyMessageBox.ShowBox("Invalid entry?", "Alert!");
                }
                if (Convert.ToInt32(txtSaleQty.Text) > Convert.ToInt32(txtAvailableQty.Text))
                {
                    MyMessageBox.ShowBox("Less Stock Available!", "Alert!");
                    return;
                }
                if (txtSaleQty.Text == "0")
                {
                    MyMessageBox.ShowBox("Wrong Entry!", "Alert!");
                    return;
                }
                else
                {
                    string strProduct = txtProductName.Text;
                    Int64 ProductId = 0;
                    string strProductName = string.Empty;
                    string[] strSplit = strProduct.Split('|');
                    if (strSplit != null && strSplit.Length > 0)
                    {
                        ProductId = Convert.ToInt64(strSplit[1]);
                        strProductName = strSplit[0];
                    }

                    if (dataGridView1.Rows.Count > 0)
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            if (ProductId.ToString() == dataGridView1.Rows[i].Cells["ProductID"].Value.ToString())
                            {
                                MyMessageBox.ShowBox("This item " + strProductName + " has already been added .? ", "Warning!");
                                return;
                            }
                        }
                    }
                    this.dataGridView1.Rows.Add(ProductId, strProductName, txtOriginalPrice.Text, txtDiscount.Text, txtCGST.Text, txtSGST.Text, txtPrice.Text, txtSaleQty.Text, txtTotalAmount.Text, txtAvailableQty.Text);
                    CalculateTotal();
                    // Get ready for the next entry.
                    txtProductName.Clear();
                    txtPrice.Clear();
                    txtTotalAmount.Clear();
                    txtSaleQty.Clear();
                    txtProductName.Focus();
                    txtOriginalPrice.Clear();
                    txtDiscount.Clear();
                    txtCGST.Clear();
                    txtSGST.Clear();
                    txtAvailableQty.Clear();
                }

            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmInvoice", "btnAddToCart_Click", ex.Message);
            }
        }

        private void txtProductName_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtProductName.Text != string.Empty && !txtProductName.Text.Contains("|"))
                {
                    MyMessageBox.ShowBox("Invalid Product choosen?", "Alert!");
                    txtProductName.Clear();
                    txtProductName.Focus();
                    txtOriginalPrice.Clear();
                    txtDiscount.Clear();
                    txtPrice.Clear();
                    txtCGST.Clear();
                    txtSGST.Clear();
                    txtAvailableQty.Clear();
                    txtSaleQty.Clear();
                    txtTotalAmount.Clear();
                    txtSaleQty.Enabled = false;
                }
                else
                {
                    string strProduct = txtProductName.Text;
                    Int64 ProductId = 0;
                    string[] strSplit = strProduct.Split('|');
                    if (strSplit != null && strSplit.Length > 0)
                    {
                        ProductId = Convert.ToInt64(strSplit[1]);
                    }
                    DataTable dtProducts = _repoProduct.GetProductById(ProductId);
                    foreach (DataRow row in dtProducts.Rows)
                    {
                        txtPrice.Text = Convert.ToString(row["Price"]);
                        if (row["Quantity"] == null || row["Quantity"].ToString() == string.Empty)
                        {
                            txtAvailableQty.Text = "0";
                        }
                        else
                        {
                            txtAvailableQty.Text = Convert.ToString(row["Quantity"]);
                        }
                        txtOriginalPrice.Text = Convert.ToString(row["ActualPrice"]);
                        txtDiscount.Text = Convert.ToString(row["Discount"]);
                        txtCGST.Text = Convert.ToString(row["CGST"]);
                        txtSGST.Text = Convert.ToString(row["SGST"]);
                    }
                    txtSaleQty.Enabled = true;
                    txtSaleQty.Focus();
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmInvoice", "txtProductName_Leave", ex.Message);
            }
        }

        private void txtSaleQty_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtSaleQty.Text, "^[0-9]*$"))
                {
                    txtSaleQty.Text = string.Empty;
                    e.Handled = true;
                    return;
                }
                else
                {
                    if (txtSaleQty.Text != string.Empty)
                    {
                        if (txtAvailableQty.Text == string.Empty)
                        {
                            txtAvailableQty.Text = "0";
                        }
                        if (Convert.ToInt32(txtSaleQty.Text) > Convert.ToInt32(txtAvailableQty.Text))
                        {
                            MyMessageBox.ShowBox("You have less Stock Available!", "Alert!");
                            return;
                        }
                        AutoCalulateTotal();
                    }
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmInvoice", "txtSaleQty_KeyUp", ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.ColumnIndex == 12)
                {
                    indexRow = e.RowIndex; // get the selected Row Index
                    DataGridViewRow row = dataGridView1.Rows[indexRow];

                    txtProductName.Text = Convert.ToString(row.Cells["ProductName"].Value);
                    txtProductName.Enabled = false;
                    txtOriginalPrice.Text = Convert.ToString(row.Cells["OriginalPrice"].Value);
                    txtDiscount.Text = Convert.ToString(row.Cells["Discount"].Value);
                    txtCGST.Text = Convert.ToString(row.Cells["CGST"].Value);
                    txtSGST.Text = Convert.ToString(row.Cells["SGST"].Value);
                    txtPrice.Text = Convert.ToString(row.Cells["Price"].Value);
                    txtSaleQty.Text = Convert.ToString(row.Cells["Qty"].Value);
                    txtTotalAmount.Text = Convert.ToString(row.Cells["TotalAmount"].Value);
                    txtAvailableQty.Text = Convert.ToString(row.Cells["aqty"].Value);
                    btnAddToCart.Visible = false;
                    btnUpdateCart.Visible = true;
                    btnCancel.Visible = true;
                    btnClear.Visible = false;
                    txtSaleQty.Focus();
                }

                if (e.ColumnIndex == 11)
                {
                    string ProductId = dataGridView1.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                    string ProductName = dataGridView1.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                    //           DialogResult dr = MessageBox.Show("Message.", "Title", MessageBoxButtons.YesNoCancel,
                    //MessageBoxIcon.Information);

                    //           if (dr == DialogResult.Yes)
                    //           {
                    //               // Do something
                    //           }
                    if (dataGridView1.Rows[e.RowIndex].Cells["Status"].Value != null)
                    {
                        if (dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString() != "False")
                        {
                            DialogResult dr = MessageBox.Show("Are you sure want to Return this Product?(" + ProductName + ")", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dr.ToString() == "Yes")
                            {
                                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(dataGridView1.Font.OriginalFontName, 9, FontStyle.Strikeout);
                                dataGridView1.Rows[e.RowIndex].Cells["Status"].Value = "False";
                                CalculateTotal();
                            }
                        }
                    }
                    else
                    {
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                        CalculateTotal();
                        //txtDiscountAmount.Clear();
                        //txtDiscountPer.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmInvoice", "dataGridView1_CellContentClick", ex.Message);
            }
        }

        private void btnUpdateCart_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow newDataRow = dataGridView1.Rows[indexRow];
                newDataRow.Cells["Qty"].Value = txtSaleQty.Text;
                newDataRow.Cells["TotalAmount"].Value = txtTotalAmount.Text;
                btnAddToCart.Visible = true;
                btnUpdateCart.Visible = false;
                btnCancel.Visible = false;
                txtProductName.Enabled = true;
                btnClear.Visible = true;
                txtProductName.Clear();
                txtSaleQty.Clear();
                txtPrice.Clear();
                txtTotalAmount.Clear();
                txtOriginalPrice.Clear();
                txtDiscount.Clear();
                txtAvailableQty.Clear();
                txtCGST.Clear();
                txtSGST.Clear();
                CalculateTotal();
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmInvoice", "btnUpdateCart_Click", ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                txtProductName.Enabled = true;
                txtProductName.Clear();
                txtSaleQty.Clear();
                txtPrice.Clear();
                txtOriginalPrice.Clear();
                txtDiscount.Clear();
                txtAvailableQty.Clear();
                txtCGST.Clear();
                txtSGST.Clear();
                btnAddToCart.Visible = true;
                btnClear.Visible = true;
                btnUpdateCart.Visible = false;
                btnCancel.Visible = false;
                txtTotalAmount.Clear();
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmInvoice", "btnCancel_Click", ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                txtProductName.Clear();
                txtSaleQty.Clear();
                txtPrice.Clear();
                txtAvailableQty.Clear();
                txtTotalAmount.Clear();
                txtProductName.Focus();
                txtOriginalPrice.Clear();
                txtDiscount.Clear();
                txtCGST.Clear();
                txtSGST.Clear();
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmInvoice", "btnClear_Click", ex.Message);
            }
        }

        private void AutoCalulateTotal()
        {
            try
            {
                double d = default(double);
                d = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtSaleQty.Text);
                txtTotalAmount.Text = d.ToString("F");
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmInvoice", "AutoCalulateTotal", ex.Message);
            }
        }

        private void CalculateTotal()
        {
            try
            {
                double d = default(double);
                if (dataGridView1.Rows.Count > 0)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (dataGridView1.Rows[i].Cells["Status"].Value == null || dataGridView1.Rows[i].Cells["Status"].Value.ToString() != "False")
                        {
                            d = d + Convert.ToDouble(dataGridView1.Rows[i].Cells["TotalAmount"].Value.ToString());
                        }
                    }
                }
                txtSubTotal.Text = d.ToString("F");
                txtGrandTotal.Text = d.ToString("F");
                CalculateDiscount();
                //txtDiscountAmount.Clear();
                //txtDiscountPer.Clear();
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmInvoice", "CalculateTotal", ex.Message);
            }
        }

        private void txtDiscountPer_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtDiscountPer.Text, "^[0-9]*$") || txtDiscountPer.Text == string.Empty)
                {
                    txtDiscountPer.Text = string.Empty;
                    txtGrandTotal.Text = txtSubTotal.Text;
                    return;
                }
                else
                {
                    CalculateDiscount();
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmInvoice", "txtDiscountPer_Leave", ex.Message);
            }
        }

        private void CalculateDiscount()
        {
            if (txtSubTotal.Text != string.Empty)
            {
                double afterDiscount = default(double);

                // var result = (txtDiscountPer.Text / 100.0) * txtSubTotal.Text;

                //decimal discount = Convert.ToDecimal(txtDiscountPer.Text);
                //var calculateDiscount = Convert.ToDouble(discount / 100);

                afterDiscount = (Convert.ToDouble(txtSubTotal.Text) - (Convert.ToDouble(txtDiscountPer.Text.ToString()) / 100) * Convert.ToDouble(txtSubTotal.Text.ToString()));
                txtDiscountAmount.Text = Convert.ToString((Convert.ToDouble(txtDiscountPer.Text.ToString()) / 100) * Convert.ToDouble(txtSubTotal.Text.ToString()));
                txtGrandTotal.Text = afterDiscount.ToString("F");
            }
            else
            {
                txtGrandTotal.Text = txtSubTotal.Text;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtSearchInvNo.Text, "^[0-9]*$") || txtSearchInvNo.Text == string.Empty)
                {
                    txtSearchInvNo.Text = string.Empty;
                    return;
                }
                else
                {
                    long InvoiceNo = Convert.ToInt64(txtSearchInvNo.Text);
                    DataSet dsInvoice = _repoInvoice.GetInVoiceDetails(InvoiceNo);
                    if (dsInvoice != null && dsInvoice.Tables[0].Rows.Count == 0)
                    {
                        MyMessageBox.ShowBox("No reocords found!", "Alert!");
                        txtSearchInvNo.Clear();
                        txtSearchInvNo.Focus();
                    }
                    else
                    {
                        EnableSearchButtons();
                        BIndInvoiceDetialsForInvoiceNo(dsInvoice);
                        if (lblIsActiveValue.Text == "Canceled" || lblIsReturnedValue.Text == "Returned")
                        {
                            btnReturnOrder.Visible = false;
                            btnCancelorder.Visible = false;
                        }
                        else if (lblIsReturnedValue.Text == "")
                        {
                            btnReturnOrder.Visible = true;
                            btnCancelorder.Visible = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmInvoice", "btnSearch_Click", ex.Message);
            }
        }

        private void EnableSearchButtons()
        {
            try
            {
                btnReturnOrder.Visible = true;
                btnCancelorder.Visible = true;
                btnCancelSearch.Visible = true;
                btnSearchPrint.Visible = true;
                btnAddToCart.Visible = false;
                btnClear.Visible = false;
                btnSavePrint.Visible = false;
                btnRemove.Visible = false;
                grpProduct.Enabled = false;
                grpInvoice.Enabled = false;
                grpCust.Enabled = false;
                pnlAccount.Enabled = false;
                //dataGridView1.Enabled = false;
                grpDesc.Enabled = false;
                lblIsActive.Visible = true;
                lblIsActiveValue.Visible = true;
                lblIsReturned.Visible = true;
                lblIsReturnedValue.Visible = true;
                lblCreatedBy.Visible = true;
                lblCreatedByValue.Visible = true;
                dataGridView1.Rows.Clear();
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmInvoice", "EnableSearchButtons", ex.Message);
            }
        }

        private void DisableSearchButtons()
        {
            try
            {
                btnReturnOrder.Visible = false;
                btnCancelorder.Visible = false;
                btnCancelSearch.Visible = false;
                btnSearchPrint.Visible = false;
                btnAddToCart.Visible = true;
                btnClear.Visible = true;
                btnSavePrint.Visible = true;
                btnRemove.Visible = true;
                grpProduct.Enabled = true;
                grpInvoice.Enabled = true;
                grpCust.Enabled = true;
                pnlAccount.Enabled = true;
                //dataGridView1.Enabled = true;
                grpDesc.Enabled = true;
                lblIsActive.Visible = false;
                lblIsActiveValue.Visible = false;
                lblIsReturned.Visible = false;
                lblIsReturnedValue.Visible = false;
                lblCreatedBy.Visible = false;
                lblCreatedByValue.Visible = false;
                txtInvoiceNo.Clear();
                dataGridView1.Rows.Clear();
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmInvoice", "DisableSearchButtons", ex.Message);
            }
        }

        private void BIndInvoiceDetialsForInvoiceNo(DataSet dsInvoice)
        {
            try
            {
                GridStructure();
                DataTable dtIncoice = dsInvoice.Tables["Table"];
                DataTable dtIncoiceDetails = dsInvoice.Tables["Table1"];
                if (dtIncoiceDetails != null)
                {
                    foreach (DataRow row in dtIncoiceDetails.Rows)
                    {
                        this.dataGridView1.Rows.Add(row["ProductId"], row["ProductName"], row["ActualPrice"], row["Discount"], row["CGST"], row["SGST"], row["Price"], row["Qty"], row["Amount"], "0", row["Status"]);
                    }
                    dataGridView1.Columns[12].Visible = false;
                    StrikeOutInActiveProduct();
                }
                if (dtIncoice != null)
                {
                    txtInvoiceNo.Text = Convert.ToString(dtIncoice.Rows[0]["InvoiceNo"]);
                    dtpInvoiceDate.Value = Convert.ToDateTime(dtIncoice.Rows[0]["InvoiceDate"].ToString());
                    txtSubTotal.Text = Convert.ToString(dtIncoice.Rows[0]["SubTotal"]);
                    txtDiscountPer.Text = Convert.ToString(dtIncoice.Rows[0]["Discount"]);
                    txtDiscountAmount.Text = Convert.ToString(dtIncoice.Rows[0]["DiscountAmt"]);
                    txtGrandTotal.Text = Convert.ToString(dtIncoice.Rows[0]["GrandTotal"]);
                    txtCustName.Text = Convert.ToString(dtIncoice.Rows[0]["Name"]);
                    txtCustAddress.Text = Convert.ToString(dtIncoice.Rows[0]["Address"]);
                    txtCustMobile.Text = Convert.ToString(dtIncoice.Rows[0]["Mobile"]);
                    txtDesc.Text = Convert.ToString(dtIncoice.Rows[0]["Notes"]);
                    cmbCashCard.Text = Convert.ToString(dtIncoice.Rows[0]["Cash"]);
                    if (dtIncoice.Rows[0]["IsActive"].ToString() == "False")
                    {
                        lblIsActiveValue.Text = "Canceled";
                    }
                    else if (dtIncoice.Rows[0]["IsActive"].ToString() == "True")
                    {
                        lblIsActiveValue.Text = "";
                    }

                    if (dtIncoice.Rows[0]["IsReturned"].ToString() == "False")
                    {
                        lblIsReturnedValue.Text = "";
                    }
                    else if (dtIncoice.Rows[0]["IsReturned"].ToString() == "True")
                    {
                        lblIsReturnedValue.Text = "Returned";
                    }

                    lblCreatedByValue.Text = dtIncoice.Rows[0]["CreatedBy"].ToString();
                }

            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmInvoice", "BIndInvoiceDetialsForInvoiceNo", ex.Message);
            }
        }

        private void StrikeOutInActiveProduct()
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
                    {
                        if (dataGridView1.Rows[i].Cells["Status"].Value.ToString() == "False")
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.Font = new Font(dataGridView1.Font.OriginalFontName, 9, FontStyle.Strikeout);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmInvoice", "StrikeOutInActiveProduct", ex.Message);
            }

        }

        public DataTable CreateDefaultTable()
        {
            DataTable dtInvoice = new DataTable();
            try
            {
                dtInvoice.Columns.Add("InvoiceNo", typeof(long));
                dtInvoice.Columns.Add("ProductId", typeof(int));
                //dtInvoice.Columns.Add("ProductName", typeof(string));
                //dtInvoice.Columns.Add("Price", typeof(decimal));
                dtInvoice.Columns.Add("Qty", typeof(int));
                dtInvoice.Columns.Add("Amount", typeof(decimal));
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmInvoice", "CreateDefaultTable", ex.Message);
            }
            return dtInvoice;
        }

        public DataTable CreateDefaultPrintTable()
        {
            DataTable dtInvoice = new DataTable();
            try
            {
                dtInvoice.Columns.Add("No.", typeof(int));
                dtInvoice.Columns.Add("Description", typeof(string));
                dtInvoice.Columns.Add("Rate", typeof(decimal));
                dtInvoice.Columns.Add("Qty", typeof(int));
                dtInvoice.Columns.Add("Discount", typeof(decimal));
                dtInvoice.Columns.Add("CGST", typeof(decimal));
                dtInvoice.Columns.Add("SGST", typeof(decimal));
                dtInvoice.Columns.Add("Amount", typeof(decimal));
                dtInvoice.Columns.Add("Status", typeof(string));
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmInvoice", "CreateDefaultPrintTable", ex.Message);
            }
            return dtInvoice;
        }

        public DataTable InvoiceTableData(DataTable dtInvoiceEmpty)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        DataRow row = dtInvoiceEmpty.NewRow();
                        row["InvoiceNo"] = txtInvoiceNo.Text;
                        row["ProductId"] = Convert.ToDouble(dataGridView1.Rows[i].Cells["ProductID"].Value.ToString());
                        //row["ProductName"] = Convert.ToString(dataGridView1.Rows[i].Cells["ProductName"].Value);
                        //row["Price"] = Convert.ToDouble(dataGridView1.Rows[i].Cells["Price"].Value.ToString()).ToString("F");
                        row["Qty"] = Convert.ToInt32(dataGridView1.Rows[i].Cells["Qty"].Value.ToString());
                        row["Amount"] = Convert.ToDouble(dataGridView1.Rows[i].Cells["TotalAmount"].Value.ToString()).ToString("F");
                        dtInvoiceEmpty.Rows.Add(row);
                        dtInvoiceEmpty.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmInvoice", "InvoiceTableData", ex.Message);
            }
            return dtInvoiceEmpty;
        }

        public DataTable InvoiceTablePrintData(DataTable dtInvoiceEmpty)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        DataRow row = dtInvoiceEmpty.NewRow();
                        row["No."] = i + 1;
                        row["Description"] = dataGridView1.Rows[i].Cells["ProductName"].Value.ToString();
                        row["Rate"] = Convert.ToDouble(dataGridView1.Rows[i].Cells["OriginalPrice"].Value.ToString()).ToString("F");
                        row["Qty"] = Convert.ToInt32(dataGridView1.Rows[i].Cells["Qty"].Value.ToString());
                        row["Discount"] = Convert.ToDouble(dataGridView1.Rows[i].Cells["Discount"].Value.ToString()).ToString("F");
                        row["CGST"] = Convert.ToDouble(dataGridView1.Rows[i].Cells["CGST"].Value.ToString()).ToString("F");
                        row["SGST"] = Convert.ToDouble(dataGridView1.Rows[i].Cells["SGST"].Value.ToString()).ToString("F");
                        row["Amount"] = Convert.ToDouble(dataGridView1.Rows[i].Cells["TotalAmount"].Value.ToString()).ToString("F");
                        row["Status"] = Convert.ToString(dataGridView1.Rows[i].Cells["Status"].Value);
                        dtInvoiceEmpty.Rows.Add(row);
                        dtInvoiceEmpty.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmInvoice", "InvoiceTablePrintData", ex.Message);
            }
            return dtInvoiceEmpty;
        }

        private void btnSavePrint_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure want to Save?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr.ToString() == "Yes")
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    //if (txtAvailableQty.Text == "0" || txtAvailableQty.Text == string.Empty)
                    //{
                    //    MyMessageBox.ShowBox("No Stocks available for the selected Product!", "Alert!");
                    //    return;
                    //}
                    if (txtCustName.Text == string.Empty)
                    {
                        MyMessageBox.ShowBox("Please Enter Customer Name", "Alert!");
                        txtCustName.Focus();
                        return;
                    }
                    if (txtCustMobile.Text == string.Empty)
                    {
                        MyMessageBox.ShowBox("Please Enter Customer Mobile", "Alert!");
                        txtCustMobile.Focus();
                        return;
                    }
                    DataTable dtInvoiceEmpty = new DataTable();
                    DataTable dtInvoiceData = new DataTable();
                    try
                    {
                        dtInvoiceEmpty = CreateDefaultTable();
                        dtInvoiceData = InvoiceTableData(dtInvoiceEmpty);
                        if (string.IsNullOrEmpty(txtInvoiceNo.Text) || GlobalVariables.glbUserId == 0)
                        {
                            MyMessageBox.ShowBox("Something went wrong,Please reloed the Form?", "Alert!");
                            ReloadParent();
                            return;
                        }
                        else
                        {
                            if (txtCustMobile.Text == string.Empty)
                            {
                                txtCustMobile.Text = "0";
                            }
                            if (txtSubTotal.Text == string.Empty)
                            {
                                txtSubTotal.Text = "0";
                            }
                            if (txtDiscountPer.Text == string.Empty)
                            {
                                txtDiscountPer.Text = "0";
                            }
                            if (txtDiscountAmount.Text == string.Empty)
                            {
                                txtDiscountAmount.Text = "0";
                            }
                            _vmInvoice.InvoiceNo = Convert.ToInt64(txtInvoiceNo.Text);
                            _vmInvoice.InvoiceDate = dtpInvoiceDate.Text;
                            _vmInvoice.SubTotal = Convert.ToDecimal(txtSubTotal.Text);
                            _vmInvoice.Discount = Convert.ToInt16(txtDiscountPer.Text);
                            _vmInvoice.DiscountAmt = Convert.ToDecimal(txtDiscountAmount.Text);
                            _vmInvoice.GrandTotal = Convert.ToDecimal(txtGrandTotal.Text);
                            _vmInvoice.Cash = cmbCashCard.Text;
                            _vmInvoice.CustomerName = txtCustName.Text;
                            _vmInvoice.CustomerMobile = Convert.ToInt64(txtCustMobile.Text);
                            _vmInvoice.CustomerAddress = txtCustAddress.Text;
                            _vmInvoice.CustomerEmail = txtEmail.Text;
                            _vmInvoice.Notes = txtDesc.Text;
                            _vmInvoice.CreatedBy = GlobalVariables.glbUserId;
                            bool isInserted = CreatedInvoice(_vmInvoice, dtInvoiceData);
                            if (isInserted)
                            {
                                //grpSearch.Visible=false;
                                //Graphics gph = this.CreateGraphics();
                                //bmp = new Bitmap(this.Size.Width, this.Size.Height, gph);
                                //Graphics mgph = Graphics.FromImage(bmp);
                                //mgph.CopyFromScreen(this.Location.X,this.Location.Y,0,0,this.Size);
                                MyMessageBox.ShowBox("Invoice Created!", "Success!");
                                PrintInvoice();
                                ReloadParent();
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        _errorLogs.LogErrors("frmInvoice", "btnSavePrint_Click", ex.Message);
                    }
                }
                else
                {
                    MyMessageBox.ShowBox("No product choosen?", "Alert!");
                    txtProductName.Focus();
                }
            }
            else
            {

            }
        }

        private void PrintInvoice()
        {
            try
            {
                Print print = new Print();
                print.lblInvoiceDate.Text = dtpInvoiceDate.Text;
                print.txtCustomerName.Text = txtCustName.Text;
                print.txtInvoiceNo.Text = txtInvoiceNo.Text;
                print.txtSubTotal.Text = txtSubTotal.Text;
                print.txtDiscount.Text = txtDiscountPer.Text;
                print.txtGrandTotal.Text = txtGrandTotal.Text;
                DataTable dtInvoicePrintEmpty = new DataTable();
                DataTable dtInvoicePrintData = new DataTable();
                dtInvoicePrintEmpty = CreateDefaultPrintTable();
                dtInvoicePrintData = InvoiceTablePrintData(dtInvoicePrintEmpty);
                print.dgvInvoice.DataSource = dtInvoicePrintData;
                print.dgvInvoice.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
                print.dgvInvoice.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
                print.ShowDialog();
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmInvoice", "PrintInvoice", ex.Message);
            }
        }

        private void ReloadParent()
        {
            try
            {
                using (frmInvoice frm = new frmInvoice())
                {
                    frm.MdiParent = this.MdiParent;
                    frm.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmInvoice", "ReloadParent", ex.Message);
            }

        }

        private bool CreatedInvoice(InvoiceViewModel invoice, DataTable dtInvoice)
        {
            bool isInserted = false;
            try
            {
                isInserted = _repoInvoice.CreateInvoiceRecord(invoice, dtInvoice);
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmInvoice", "CreatedInvoice", ex.Message);
            }
            return isInserted;
        }

        private void txtCustMobile_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCustMobile.Text, "^[0-9]*$") || txtCustMobile.Text == string.Empty)
            {
                txtCustMobile.Text = string.Empty;
                return;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                if (bmp != null)
                {
                    e.Graphics.DrawImage(bmp, 0, 0);
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmInvoice", "printDocument1_PrintPage", ex.Message);
            }
        }

        private void txtSearchInvNo_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtSearchInvNo.Text, "^[0-9]*$") || txtSearchInvNo.Text == string.Empty)
            {
                txtSearchInvNo.Text = string.Empty;
                return;
            }
        }

        private void btnCancelSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ReloadParent();
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmInvoice", "btnCancelSearch_Click", ex.Message);
            }
        }

        private void btnSearchPrint_Click(object sender, EventArgs e)
        {
            try
            {
                PrintInvoice();
            }
            catch (Exception ex)
            {
            }
        }

        private void btnReturnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure want to Return this Order?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr.ToString() == "Yes")
                {
                    long InvoiceNo = Convert.ToInt64(txtSearchInvNo.Text);
                    int i = UpdateInvoiceandStock("R", InvoiceNo);
                    if (i > 0)
                    {
                        MyMessageBox.ShowBox("InvoiceNo:" + InvoiceNo + " Order Returned Successfully", "Success!");
                    }
                    else
                    {
                        MyMessageBox.ShowBox("Error", "Error!");
                    }
                    ReloadParent();
                }

            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmInvoice", "btnReturnOrder_Click", ex.Message);
            }
        }

        private void btnCancelorder_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure want to Cancel this Order?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr.ToString() == "Yes")
                {
                    long InvoiceNo = Convert.ToInt64(txtSearchInvNo.Text);
                    int i = UpdateInvoiceandStock("C", InvoiceNo);
                    if (i > 0)
                    {
                        MyMessageBox.ShowBox("InvoiceNo:" + InvoiceNo + " Order Returned Successfully", "Success!");
                    }
                    else
                    {
                        MyMessageBox.ShowBox("Error", "Error!");
                    }
                    ReloadParent();
                }

            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmInvoice", "btnCancelorder_Click", ex.Message);
            }
        }

        private int UpdateInvoiceandStock(string Type, long InvoiceNo)
        {
            int isUpdated = 0;
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {

                    DataTable dtStockDetails = new DataTable();
                    dtStockDetails.Columns.Add("InvoiceNo", typeof(long));
                    dtStockDetails.Columns.Add("ProductId", typeof(int));
                    dtStockDetails.Columns.Add("Qty", typeof(int));
                    dtStockDetails.Columns.Add("Status", typeof(bool));
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        DataRow row = dtStockDetails.NewRow();
                        row["InvoiceNo"] = string.IsNullOrEmpty(txtInvoiceNo.Text) ? 0 : (int?)Convert.ToInt64(txtInvoiceNo.Text);
                        row["ProductId"] = dataGridView1.Rows[i].Cells["ProductID"].Value.ToString();
                        row["Qty"] = dataGridView1.Rows[i].Cells["Qty"].Value.ToString();
                        row["Status"] = Convert.ToBoolean(dataGridView1.Rows[i].Cells["Status"].Value.ToString());
                        dtStockDetails.Rows.Add(row);
                        dtStockDetails.AcceptChanges();
                    }
                    isUpdated = _repoStock.UpdateReturnStock(dtStockDetails, InvoiceNo, Type, GlobalVariables.glbUserId);
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmInvoice", "UpdateInvoiceandStock", ex.Message);
            }
            return isUpdated;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                ReloadParent();
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmInvoice", "btnRemove_Click", ex.Message);
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            try
            {
                Regex rEMail = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
                if (txtEmail.Text.Length > 0)
                {
                    if (!rEMail.IsMatch(txtEmail.Text))
                    {
                        MyMessageBox.ShowBox("Invalid Email Address!", "Alert!");
                        txtEmail.Clear();
                        txtEmail.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmInvoice", "txtEmail_Leave", ex.Message);
            }
        }
    }
}
