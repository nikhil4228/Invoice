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

namespace Invoice
{
    public partial class Category : MetroForm
    {
        private ErrorLogs _errorLogs;
        private CategoryRepo _objCat;
        public static int SelectedCategoryId ;
        public Category()
        {
            _errorLogs = new ErrorLogs();
            _objCat = new CategoryRepo();
            InitializeComponent();
        }
        private void Category_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            DataTable dtcat = new DataTable("tblCategory");
            try
            {
                dtcat = _objCat.GetAllCategories();
                if (dtcat != null)
                {
                    dataGridView1.DataSource = dtcat;
                }
                //setGridStyle();
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("Category", "Category_Load", ex.Message);
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                using (CreateCategory createCategory = new CreateCategory())
                {
                    createCategory.MdiParent = this.MdiParent;
                    createCategory.ShowDialog();
                    //createCategory.Show();
                    loadData();
                }
                CreateCategory createCategoryObj = new CreateCategory();
                createCategoryObj.Hide();
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("Category", "btnAddCategory_Click", ex.Message);
            }
        }

        //private void setGridStyle()
        //{
        //    try
        //    {

        //        DataGridViewColumn column = dataGridView1.Columns[0];
        //        column.Width = 80;
        //        DataGridViewColumn column1 = dataGridView1.Columns[1];
        //        column1.Width = 290;
        //        DataGridViewColumn column2 = dataGridView1.Columns[2];
        //        column2.Width = 400;
        //        DataGridViewColumn column3 = dataGridView1.Columns[3];
        //        column3.Width = 150;
        //        DataGridViewColumn column4 = dataGridView1.Columns[4];
        //        column4.Width = 125;

        //        dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Orange;
        //        dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //        dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //        dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //        dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //        dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //        dataGridView1.Columns[0].HeaderCell.Style.Font = new Font("Palatino Linotype", 10);
        //        dataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Palatino Linotype", 10);
        //        dataGridView1.Columns[2].HeaderCell.Style.Font = new Font("Palatino Linotype", 10);
        //        dataGridView1.Columns[3].HeaderCell.Style.Font = new Font("Palatino Linotype", 10);
        //        dataGridView1.Columns[4].HeaderCell.Style.Font = new Font("Palatino Linotype", 10);

        //        this.dataGridView1.Rows.Add(1, 2, 3, 4, 5);
        //    }
        //    catch (Exception ex)
        //    {
        //        _errorLogs.LogErrors("Category", "setGridStyle", ex.Message);
        //    }
        //}

        //EDIT CLICK

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedCategoryId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            //MessageBox.Show(SelectedCategoryId + "Id clicked");
            try
            {
                if (e.ColumnIndex == 0)
                {
                    //edit the item                    
                    try
                    {
                        using (UpdateCategory updateCategory = new UpdateCategory())
                        {
                            updateCategory.MdiParent = this.MdiParent;
                            updateCategory.ShowDialog();
                            //MessageBox.Show("The Category is Updated successfully", "Alert", MessageBoxButtons.OK);
                            //updateCategory.Hide();
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                //colindex = 1 
                else if (e.ColumnIndex == 1)
                {
                    DialogResult dialouge = MessageBox.Show("Are You Sure you want to DELETE !", "ALERT", MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk);
                    if (dialouge==DialogResult.Yes)
                    {
                        //Delete the item this returns us the ststus if the item is deleted or no IF the status returned is 0 that means the category is deleted else there are other products that belong to the category
                        int deletedStatus = _objCat.DeleteCategoryById(SelectedCategoryId, GlobalVariables.glbUserId);
                        if (deletedStatus > 0)
                        {
                            MessageBox.Show("The Category os not deleted Please check there are some other Products that belong to the category", "Alert", MessageBoxButtons.OK);
                        }
                        else if (deletedStatus == 0)
                        {
                            MessageBox.Show("The Category is deleted successfully", "Alert", MessageBoxButtons.OK);
                        }
                    }
                    else if (dialouge == DialogResult.No)
                    {

                    }
       
                }
            }
            catch (Exception)
            {

                throw;
            }
            loadData();
        }






    }
}
