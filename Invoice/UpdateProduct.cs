using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using InvoiceBLL;
using Invoice.Helper;
using System.IO;
using System.Drawing.Imaging;

namespace Invoice
{
    public partial class UpdateProduct : MetroForm
    {
        private ProductRepo _objPro;
        private ErrorLogs _errorLogs;
       int selectedProductId = Products.SelectedProductId;
        public UpdateProduct()
        {
            _objPro = new ProductRepo();
            _errorLogs = new ErrorLogs();
            InitializeComponent();
        }
        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            loadCategoryComboBoxData();
            loadData();
        }
        public int loadSubCategoryComboBox(int categoryId)
        {
            int isSubCategoryPresent = 0;
            try
            {
                DataTable dtSubCategory = _objPro.GetSubCategoriesByCatId(categoryId);
                DataRow dr = dtSubCategory.NewRow();
                dr["SubCategoryId"] = 0;
                dr["Name"] = "Select Sub Category";
                dtSubCategory.Rows.InsertAt(dr, 0);
                if (dtSubCategory.Rows.Count > 1)
                {
                    cbSubCategory.DataSource = dtSubCategory;
                    cbSubCategory.ValueMember = "SubCategoryId";
                    cbSubCategory.DisplayMember = "Name";
                    isSubCategoryPresent = 1;
                }
                else if (dtSubCategory.Rows.Count == 1)
                {
                    cbSubCategory.DataSource = dtSubCategory;
                    cbSubCategory.ValueMember = "SubCategoryId";
                    cbSubCategory.DisplayMember = "Name";
                    cbSubCategory.Enabled = false;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return isSubCategoryPresent;
        }

        public void loadCategoryComboBoxData()
        {

            try
            {
                DataTable dtCategory = _objPro.getCategories();
                DataRow dr = dtCategory.NewRow();
                dr["CategoryId"] = 0;
                dr["Name"] = "Select Category";
                dtCategory.Rows.InsertAt(dr, 0);
                if (dtCategory != null)
                {
                    cbCategory.DataSource = dtCategory;
                    cbCategory.ValueMember = "CategoryId";
                    cbCategory.DisplayMember = "Name";
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("CreateProduct", "BindCategory", ex.Message);
            }
        }

        public void loadData()
        {
            DataTable prodtable = _objPro.GetProductById(selectedProductId);
            if (prodtable.Rows.Count > 0)
            {
                txtProductName.Text = prodtable.Rows[0]["Name"].ToString();
                cbCategory.SelectedValue = prodtable.Rows[0]["CategoryId"];
                int isSubCategoryPresent = loadSubCategoryComboBox(Convert.ToInt32(cbCategory.SelectedValue.ToString()));
                if (isSubCategoryPresent != 0)
                {
                    cbSubCategory.SelectedValue = prodtable.Rows[0]["SubCategoryId"];
                }
                txtOriginalPrice.Text = prodtable.Rows[0]["ActualPrice"].ToString();
                txtCGST.Text = prodtable.Rows[0]["CGST"].ToString();
                txtSGST.Text = prodtable.Rows[0]["SGST"].ToString();
                txtPrice.Text = prodtable.Rows[0]["Price"].ToString();
                txtDescription.Text = prodtable.Rows[0]["Features"].ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CreateProduct createProduct = new CreateProduct();
            int productId = selectedProductId;
            string name = txtProductName.Text;
            string description = txtDescription.Text;
            double originalPrice = 0;
            double SGST = 0;
            double CGST = 0;
            double discount = 0;
            if (txtOriginalPrice.Text !=string.Empty)
            {
                 originalPrice = Convert.ToDouble(txtOriginalPrice.Text);
            }           
            if (txtSGST.Text != string.Empty)
            {
                 SGST = Convert.ToDouble(txtSGST.Text);
            }
            if (txtCGST.Text != string.Empty)
            {
                 CGST = Convert.ToDouble(txtCGST.Text);
            }
            if (txtDiscount.Text != string.Empty)
            {
                 discount = Convert.ToDouble(txtDiscount.Text);
            }
            byte[] imageBT = null;
            Image image = pictureBox1.Image;
            if (image != null)
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    image.Save(memoryStream, ImageFormat.Jpeg);
                    imageBT = memoryStream.ToArray();
                }
            }
            int categoryId = Convert.ToInt32(cbCategory.SelectedValue);
            int subCategoryID = Convert.ToInt32(cbSubCategory.SelectedValue);
            double price = Convert.ToDouble(txtPrice.Text);
            int modifiedUserId = GlobalVariables.glbUserId;
            _objPro.updateProduct(productId, name, description, originalPrice, CGST, SGST, discount, imageBT, categoryId, subCategoryID, price, modifiedUserId);
            //_objPro.updateProduct(7, "name", "desc", 77.77f, 5, 5, 10, null, 0, 1, 998.78, modifiedUserId);
            MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK);
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            //code to Close this form
        }

        private void btnBrows_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void Calculate()
        {
            try
            {
                double afterDiscount = default(double);
                double afterTax = default(double);
                double tax = default(double);
                //string CGSTPrice = string.Empty;
                //string SGSTPrice = string.Empty;

                if (txtDiscount.Text.Trim() != string.Empty || txtDiscount.Text == "0")
                {
                    if (txtCGST.Text == string.Empty || txtSGST.Text == string.Empty)
                    {
                        afterDiscount = (Convert.ToDouble(txtOriginalPrice.Text) - (Convert.ToDouble(txtDiscount.Text) / 100) * Convert.ToDouble(txtOriginalPrice.Text.ToString()));
                        txtPrice.Text = afterDiscount.ToString("F");
                    }
                    else
                    {
                        afterDiscount = (Convert.ToDouble(txtOriginalPrice.Text) - (Convert.ToDouble(txtDiscount.Text) / 100) * Convert.ToDouble(txtOriginalPrice.Text.ToString()));
                        tax = (Convert.ToDouble(txtCGST.Text) + Convert.ToDouble(txtSGST.Text));

                        //populating data for CGST and SGST for reference or a quick view
                        //CGSTPrice = Convert.ToString(Convert.ToDouble(afterDiscount) + (Convert.ToDouble(txtCGST.Text) / 100) * Convert.ToDouble(afterDiscount));
                        //SGSTPrice = Convert.ToString(Convert.ToDouble(afterDiscount) + (Convert.ToDouble(txtSGST.Text) / 100) * Convert.ToDouble(afterDiscount));

                        afterTax = (Convert.ToDouble(afterDiscount) + (tax / 100) * Convert.ToDouble(afterDiscount));
                        txtPrice.Text = afterTax.ToString("F");
                    }
                }
                else if (txtCGST.Text != string.Empty && txtSGST.Text != string.Empty)
                {
                    tax = (Convert.ToDouble(txtCGST.Text) + Convert.ToDouble(txtSGST.Text));
                    afterTax = (Convert.ToDouble(txtOriginalPrice.Text) + (tax / 100) * Convert.ToDouble(txtOriginalPrice.Text));
                    txtPrice.Text = afterTax.ToString("F");
                }
                else
                {
                    txtPrice.Text = txtOriginalPrice.Text;
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("CreateProduct", "Calculate", ex.Message);
            }
        }

        private void txtCGST_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtOriginalPrice.Text == string.Empty)
                {
                    MessageBox.Show("Please enter Original Price!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOriginalPrice.Focus();
                    return;
                }
                else
                {
                    if (!System.Text.RegularExpressions.Regex.IsMatch(txtCGST.Text, "^[0-9]*$"))
                    {
                        txtCGST.Text = string.Empty;
                        return;
                    }
                    else
                    {
                        Calculate();
                    }
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("CreateProduct", "txtCGST_Leave", ex.Message);
            }

        }

        private void txtSGST_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtOriginalPrice.Text == string.Empty)
                {
                    MessageBox.Show("Please enter Original Price!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOriginalPrice.Focus();
                    return;
                }
                else
                {
                    if (!System.Text.RegularExpressions.Regex.IsMatch(txtSGST.Text, "^[0-9]*$"))
                    {
                        txtSGST.Text = string.Empty;
                        return;
                    }
                    else
                    {
                        Calculate();
                    }
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("CreateProduct", "txtSGST_Leave", ex.Message);
            }
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtOriginalPrice.Text == string.Empty)
                {
                    MessageBox.Show("Please enter Original Price!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOriginalPrice.Focus();
                    return;
                }
                else
                {
                    if (!System.Text.RegularExpressions.Regex.IsMatch(txtDiscount.Text, "^[0-9]*$"))
                    {
                        txtDiscount.Text = string.Empty;
                        txtPrice.Text = txtOriginalPrice.Text;
                        return;
                    }
                    else
                    {
                        if (txtDiscount.Text == string.Empty)
                        {
                            txtDiscount.Text = string.Empty;
                            txtPrice.Text = txtOriginalPrice.Text;
                        }
                        else
                        {
                            Calculate();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("CreateProduct", "txtDiscount_Leave", ex.Message);
            }
        }

        private void txtOriginalPrice_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtOriginalPrice.Text, @"^((\d+)((\.\d{1,2})?))$"))
                {
                    MessageBox.Show("Invalid Price!(it should be a number)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOriginalPrice.Focus();
                    txtPrice.Clear();
                    txtDiscount.Clear();
                    txtCGST.Clear();
                    return;
                }
                else
                {
                    Calculate();
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("CreateProduct", "txtOriginalPrice_Leave", ex.Message);
            }
        }
    }
}
