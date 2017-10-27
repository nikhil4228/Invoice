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
using MetroFramework.Forms;
using Invoice.Helper;
using System.IO;
using System.Drawing.Imaging;

namespace Invoice
{
    public partial class UpdateCategory : MetroForm
    {
        private CategoryRepo _objCat;
        private ErrorLogs _errorLogs;
        int SelectedCategoryId= Category.SelectedCategoryId;
        public UpdateCategory()
        {
            _errorLogs = new ErrorLogs();
            _objCat = new CategoryRepo();
            InitializeComponent();
        }
        private void UpdateCategory_Load(object sender, EventArgs e)
        {
            // CategoryId = Category.SelectedCategoryId;
            try
            {
                loadData(SelectedCategoryId);
                btnClear.Hide();
            }
            catch (Exception)
            {
                throw;
            }
         
        }
        public void loadData(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                dt =  _objCat.GetCategoryById(id);
                if (dt.Rows.Count > 0)
                {
                    txtCatName.Text = dt.Rows[0]["Name"].ToString();
                    txtCatDescription.Text = dt.Rows[0]["Description"].ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = txtCatName.Text;
                string Description = txtCatDescription.Text;
                byte[] imagebt = null;
                int CategoryId = SelectedCategoryId;
                Image image = pictureBox1.Image;
                if (image != null )
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        image.Save(memoryStream, ImageFormat.Jpeg);
                        imagebt = memoryStream.ToArray();
                    }
                }
                _objCat.UpdateCategory(Name,Description, imagebt, GlobalVariables.glbUserId, SelectedCategoryId);
            }
            catch (Exception)
            {

                throw;
            }
            MessageBox.Show("Updated", "Status", MessageBoxButtons.OK);
            UpdateCategory currentFrm = new UpdateCategory();
            this.Hide();
        }
             
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
                DialogResult res = openFileDialog1.ShowDialog();
                if (res == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("CreateCategory", "button1_Click", ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
