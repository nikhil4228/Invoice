using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using InvoiceBLL;
using MetroFramework.Forms;
using Invoice.Helper;

namespace Invoice
{
    public partial class Products : MetroForm
    {
        private ErrorLogs _errorLogs;
        private ProductRepo _objPro;
        public static int SelectedProductId;
        public Products()
        {
            _errorLogs = new ErrorLogs();
            _objPro = new ProductRepo();
            InitializeComponent();
        }


        private void btnProduct_Click(object sender, EventArgs e)
        {
            try
            {
                using (CreateProduct createProduct = new CreateProduct())
                {
                    createProduct.MdiParent = this.MdiParent;
                    createProduct.ShowDialog();
                }
                loadData();
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("Products", "btnProduct_Click", ex.Message);
            }

        }

        private void Products_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            try
            {
                DataTable dtCategory = new DataTable();
                dtCategory = _objPro.getCategories();
                DataRow dr = dtCategory.NewRow();
                dr["CategoryId"] = 0;
                dr["Name"] = "Select - (Display All) ";
                dtCategory.Rows.InsertAt(dr, 0);
                cbCategory.DataSource = dtCategory;
                cbCategory.ValueMember = "CategoryId";
                cbCategory.DisplayMember = "Name";
            }
            catch (Exception)
            {

                throw;
            }
            try
            {
                DataTable dtpro = _objPro.GetAllProduct();
                if (dtpro != null)
                {
                    dataGridView1.DataSource = dtpro;
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("Products", "Products_Load", ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //  MessageBox.Show(e.ColumnIndex + "Is clicked");
            SelectedProductId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            if (e.ColumnIndex == 0)
            {//code to navigate to edit and update
                using (UpdateProduct updateProduct = new UpdateProduct())
                {
                    updateProduct.MdiParent = this.MdiParent;
                    updateProduct.ShowDialog();
                }
                loadData();
                //UpdateProduct updateProductObj = new UpdateProduct();
                //updateProductObj.Hide();
            }
            else if (e.ColumnIndex == 1)
            {
                DialogResult dialouge = MessageBox.Show("Are You Sure you want to DELETE !", "ALERT", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dialouge == DialogResult.Yes)
                {
                    //Code to delete the data depending on the status if the ststus is 0 we can elete the product else we need to show a message saying tht the product cannot be deleted
                    int status = _objPro.deleteProductById(SelectedProductId, GlobalVariables.glbUserId);
                    if (status > 0)
                    {
                        MessageBox.Show("You cannot Delete!!  Please check the Available Stock", "Alert", MessageBoxButtons.OK);
                    }
                    else if (status == 0)
                    {
                        MessageBox.Show("Deleted Successfully", "Deleted", MessageBoxButtons.OK);
                    }
                }
                loadData();
            }
        }

        //private void cbCategory_Leave(object sender, EventArgs e)
        //{
        //    int categoryId = Convert.ToInt32(cbCategory.SelectedValue);
        //    try
        //    {
        //        DataTable dtpro = _objPro.GetAllProductsByCategory(categoryId);
        //        if (dtpro != null)
        //        {
        //            dataGridView1.DataSource = dtpro;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //       throw;
        //    }
        //}

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtPro = new DataTable();
            try
            {
                if (cbCategory.SelectedValue.ToString()!= "System.Data.DataRowView")
                {
                    int categoryId = Convert.ToInt32(cbCategory.SelectedValue);
                    if (categoryId==0)
                    {
                        dtPro = _objPro.GetAllProduct();
                        if (dtPro != null)
                        {
                            dataGridView1.DataSource = dtPro;
                        }
                    }
                    else if (categoryId>0)
                    {
                        dtPro = _objPro.GetAllProductsByCategory(categoryId);
                        if (dtPro != null)
                        {
                            dataGridView1.DataSource = dtPro;
                        }
                    }                     
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
