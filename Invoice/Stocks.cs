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

namespace Invoice
{
    public partial class Stocks : MetroForm
    {
        private StockRepo _objStock;
        public static int selectedProductId;
        public Stocks()
        {
            InitializeComponent();
            _objStock = new StockRepo();
        }
        public void loadData()
        {
            try
            {
                DataTable dtCategory = new DataTable();
                dtCategory = _objStock.getAllCategories();
                DataRow dr = dtCategory.NewRow();
                dr["CategoryId"] = 0;
                dr["Name"] = "Select ";
                dtCategory.Rows.InsertAt(dr, 0);
                cbCategory.DataSource = dtCategory;
                cbCategory.ValueMember = "CategoryId";
                cbCategory.DisplayMember = "Name";
            }
            catch (Exception)
            {

                throw;
            }
            DataTable dtStock = new DataTable();
            try
            {
                dtStock = _objStock.getAllStocks();
                dataGridView1.DataSource = dtStock;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Stocks_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // col index = 0 write code to display stock detals 
            //MessageBox.Show(e.RowIndex + "Column :" + e.ColumnIndex);
            //MessageBox.Show("Column1 = "+dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString());
            if (!string.IsNullOrEmpty(Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value)))
            {
                selectedProductId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString());
            }
            using (StockDetails stockdetails = new StockDetails())
            {
                stockdetails.MdiParent = this.MdiParent;
                stockdetails.ShowDialog();
            }
            //MessageBox.Show(e.ColumnIndex + " column");
        }
        
        private void cbCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbCategory.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    int categoryId = Convert.ToInt32(cbCategory.SelectedValue.ToString());
                    DataTable dtStock = new DataTable();
                    if (categoryId == 0)
                    {
                        dtStock = _objStock.getAllStocks();
                        dataGridView1.DataSource = dtStock;
                    }
                    else if (categoryId>0)
                    {
                        dtStock = _objStock.getAllStocksByCategory(categoryId);
                        dataGridView1.DataSource = dtStock;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //private void cbCategory_Leave(object sender, EventArgs e)
        //{
          
        //    if (categoryId > 0)
        //    {
        //        try
        //        {
                  
        //        }
        //        catch (Exception)
        //        {

        //            throw;
        //        }
        //    }
        //}
    }
}
