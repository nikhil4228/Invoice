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
using System.Drawing.Imaging;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using Invoice.Helper;
using System.Text.RegularExpressions;
using InvoiceBLL;


namespace Invoice
{
    public partial class CreateProduct : MetroForm
    {
        private ErrorLogs _errorLogs;
        private ProductRepo _repoProduct;
        public CreateProduct()
        {
            _errorLogs = new ErrorLogs();
            _repoProduct = new ProductRepo();
            InitializeComponent();
        }
        private void CreateProduct_Load(object sender, EventArgs e)
        {
            BindCategory();
        }
        private void BindCategory()
        {
            try
            {
                DataTable dtCategory = _repoProduct.getCategories();
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
        private void BindSubCategory(int CategoryId)
        {
            try
            {
                DataTable dtSubCategory = _repoProduct.GetSubCategoriesByCatId(CategoryId);
                if (dtSubCategory != null)
                {
                    cbSubCategory.DataSource = dtSubCategory;
                    cbSubCategory.DisplayMember = "Name";
                    cbSubCategory.ValueMember = "SubCategoryId";
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("CreateProduct", "BindSubCategory", ex.Message);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)  
        {
            try
            {
                if (txtProductName.Text == "")
                {
                    MessageBox.Show("Please enter ProductName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProductName.Focus();
                    return;
                }
                if (txtOriginalPrice.Text == "")
                {
                    MessageBox.Show("Please enter Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOriginalPrice.Focus();
                    return;
                }
                if (cbCategory.SelectedIndex == 0)
                {
                    MessageBox.Show("Please select the Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbCategory.Focus();
                    return;
                }
                string strProductName = string.Empty;
                int CategoryId = 0;
                int SubCategoryId = 0;
                decimal Price = 0;
                decimal OriginalPrice = 0;
                int Discount = 0;
                decimal CGST= 0;
                decimal SGST = 0;
                string strProductDescription = string.Empty;

                strProductName = txtProductName.Text;
                CategoryId = Convert.ToInt32(cbCategory.SelectedValue);
                SubCategoryId = Convert.ToInt32(cbSubCategory.SelectedValue);
                OriginalPrice = Convert.ToDecimal(txtOriginalPrice.Text);
                if (txtDiscount.Text != string.Empty)
                {
                    Discount = Convert.ToInt32(txtDiscount.Text);
                }
                if (txtCGST.Text != string.Empty)
                {
                    CGST = Convert.ToDecimal(txtCGST.Text);
                }
                if (txtSGST.Text != string.Empty)
                {
                    SGST = Convert.ToDecimal(txtSGST.Text);
                }
                Price = Convert.ToDecimal(txtPrice.Text);
                strProductDescription = txtDescription.Text;

                Image image = pictureBox1.Image;
                byte[] imageBt = null;
                string imageName;
                if (image != null)
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        image.Save(memoryStream, ImageFormat.Jpeg);
                        imageBt = memoryStream.ToArray();
                    }
                }
                //else
                //{
                //    imageName = @"../../Resource/images/no-image-icon-15.png";
                //    //Initialize a file stream to read the image file
                //    FileStream fs = new FileStream(@imageName, FileMode.Open, FileAccess.Read);
                //    //Initialize a byte array with size of stream
                //    imageBt = new byte[fs.Length];
                //    //Read data from the file stream and put into the byte array
                //}


                int isInserted = _repoProduct.insertProduct(strProductName, CategoryId, SubCategoryId, OriginalPrice, Discount, CGST,SGST, Price, strProductDescription, imageBt, GlobalVariables.glbUserId);
                if (isInserted > 0)
                {
                    txtProductName.Clear();
                    txtOriginalPrice.Clear();
                    txtDescription.Clear();
                    txtPrice.Clear();
                    txtDiscount.Clear();
                    txtCGST.Clear();
                    txtSGST.Clear();
                    pictureBox1.Image = null;
                    MessageBox.Show("Product Created Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    using (Products frmProduct = new Products())
                    {
                        frmProduct.Refresh();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Product already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("CreateProduct", "btnSave_Click", ex.Message);
            }
        }

        private void btnBrows_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
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

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int CategoryId = 0;
                if (cbCategory.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    CategoryId = Convert.ToInt32(cbCategory.SelectedValue);
                }
               //if(CategoryId == 0)
               // {
               //     MessageBox.Show("Please select the Category", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               // }
                BindSubCategory(CategoryId);
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("CreateProduct", "cbCategory_SelectedIndexChanged", ex.Message);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                txtProductName.Clear();
                txtOriginalPrice.Clear();
                txtDiscount.Clear();
                txtCGST.Clear();
                txtSGST.Clear();
                cbCategory.SelectedIndex = 0;
                cbSubCategory.SelectedIndex = 0;
                txtPrice.Clear();
                txtDescription.Text=string.Empty;
            }
            catch (Exception ex)
            {
            }
        }
    }
}
