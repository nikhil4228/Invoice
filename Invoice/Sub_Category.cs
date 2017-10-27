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
    public partial class Sub_Category : MetroForm
    {
        private ErrorLogs _errorLogs;
        private SubCategoryRepo _objSubCat;
        public Sub_Category()
        {
            _errorLogs = new ErrorLogs();
            _objSubCat = new SubCategoryRepo();
            InitializeComponent();
        }
        private void SubCategory_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtSubcat = _objSubCat.GetAllSubCategory();
                if (dtSubcat != null)
                {
                    dataGridView1.DataSource = dtSubcat;
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("Sub_Category", "SubCategory_Load", ex.Message);
            }
        }

        private void btnSubCat_Click(object sender, EventArgs e)
        {
            try
            {
                using (CreateSubCategory subCategory = new CreateSubCategory())
                {
                    subCategory.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("Sub_Category", "btnSubCat_Click", ex.Message);
            }
        }
    }
}
