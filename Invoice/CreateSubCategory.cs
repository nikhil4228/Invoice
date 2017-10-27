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
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing.Imaging;
using System.IO;
using InvoiceBLL;
using Invoice.Helper;

namespace Invoice
{
    public partial class CreateSubCategory : MetroForm
    {
        string conStr = ConfigurationManager.AppSettings["conStr"].ToString();
        private ErrorLogs _errorLogs;
        public CreateSubCategory()
        {
            InitializeComponent();
        }
        private void CreateSubCategory_Load_1(object sender, EventArgs e)
        {
            BindCategory();
        }
        void BindCategory()
        {
            SqlConnection cn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand("Select * From Category", cn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cbCategory.DataSource = dt;
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "CategoryId";
        }
        public bool insertSubCategory(string Name, string Description, int categoryId, byte[] Image, int CreatedBy)
        {
            bool isInserted = false;
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    using (SqlCommand cmd = new SqlCommand("Inv_CreateSubCategory", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Name", Name);
                        cmd.Parameters.Add("@Description", Description);
                        cmd.Parameters.Add("@CategoryId", CategoryId);
                        cmd.Parameters.Add("@Image", Image);
                        cmd.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        int i = cmd.ExecuteNonQuery();
                    }
                }
                isInserted = true;
            }
            catch (Exception ex)
            {

            }
            return isInserted;
        }
        public DataTable GetAllSubCategories()
        {
            DataTable dtCat = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection("conStr"))
                {
                    SqlCommand cmd = new SqlCommand("Insert into DEEPAK.Invoice(Name,Description,Image) values('" + this.txtSubCatName.Text + "'," + this.cbCategory.Text + ",'" + this.txtSubCatDescription.Text + "','" + this.pictureBox1.Image + "')", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtCat);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return dtCat;

        }
        private void bntBrowse_Click_1(object sender, EventArgs e)
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

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSubCatName.Text == "")
                {
                    MessageBox.Show("Please enter SubcategoryName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSubCatName.Focus();
                    return;
                }

                string strSubCategoryName = string.Empty;
                int CategoryId;
                string strSubCategoryDescription = string.Empty;
                byte Product;

                strSubCategoryName = txtSubCatName.Text;
                CategoryId = Convert.ToInt32(cbCategory.SelectedValue.ToString());
                strSubCategoryDescription = txtSubCatDescription.Text;

                Image image = pictureBox1.Image;
                byte[] imageBt = null;
                string imageName;
                int CreatedBy = GlobalVariables.glbUserId;
                if (image != null)
                {
                    MemoryStream memoryStream = new MemoryStream();
                    image.Save(memoryStream, ImageFormat.Jpeg);
                    imageBt = memoryStream.ToArray();
                }
                else
                {
                    imageName = @"~/Resource/images/no-image-icon-15.png";
                    //Initialize a file stream to read the image file
                    FileStream fs = new FileStream(@imageName, FileMode.Open, FileAccess.Read);
                    //Initialize a byte array with size of stream
                    imageBt = new byte[fs.Length];
                    //Read data from the file stream and put into the byte array
                }

                SubCategoryRepo repoSubCat = new SubCategoryRepo();
                int isInserted = repoSubCat.CreateSubCategory(strSubCategoryName, strSubCategoryDescription, CategoryId, imageBt, CreatedBy);

                if (isInserted > 0)
                {
                    txtSubCatName.Clear();
                    txtSubCatDescription.Clear();
                    pictureBox1.Image = null;
                    MessageBox.Show("SubCategory Created Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("SubCategory Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            catch (Exception)
            {

                throw;
            }
        }

        public SqlDbType CategoryId { get; set; }


    }
}

