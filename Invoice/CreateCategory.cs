using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using MetroFramework.Forms;
using System.IO;
using System.Drawing.Imaging;
using InvoiceBLL;
using Invoice.Helper;

namespace Invoice
{
    public partial class CreateCategory : MetroForm
    {
        string conStr = ConfigurationManager.AppSettings["conStr"].ToString();
        private ErrorLogs _errorLogs;
        private CategoryRepo _repoCat;
        public CreateCategory()
        {
            _errorLogs = new ErrorLogs();
            _repoCat = new CategoryRepo();
            InitializeComponent();
        }

        private void CreateCategory_Load(object sender, EventArgs e)
        {

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

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtCatName.Text == "")
                {
                    MessageBox.Show("Please enter category", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCatName.Focus();
                    return;
                }

                string strCategoryName = string.Empty;
                string strCategoryDescription = string.Empty;
                byte bytyCategoryImage;

                strCategoryName = txtCatName.Text;
                strCategoryDescription = txtCatDescription.Text;

                Image image = pictureBox1.Image;
                byte[] imageBt = null;
                int CreatedBy = GlobalVariables.glbUserId;
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
                //    imageName = @"../../Resource/images/no-image-icon-15.png";  //C:\Users\Pspl\Downloads\Invoice_v3\Invoice_v2\Invoice\Invoice\Resource\Images\no-image-icon-15.png
                //    //Initialize a file stream to read the image file
                //    FileStream fs = new FileStream(@imageName, FileMode.Open, FileAccess.Read);
                //    //Initialize a byte array with size of stream
                //    imageBt = new byte[fs.Length];
                //    //Read data from the file stream and put into the byte array
                //}

                int isInsrted = _repoCat.CreateCategory(strCategoryName, strCategoryDescription, imageBt, CreatedBy);

                if (isInsrted > 0)
                {
                    txtCatName.Clear();
                    txtCatDescription.Clear();
                    pictureBox1.Image = null;
                    MessageBox.Show("Category Created Successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Category cat = new Category();
                    //cat.loadData();
                }
                else
                {
                    MessageBox.Show("Category already Exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("CreateCategory", "btnSave_Click_1", ex.Message);
            }
            this.Hide();
        }
    }
}
