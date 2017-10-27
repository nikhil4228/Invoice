using Invoice.Helper;
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

namespace Invoice
{
    public partial class Parent : MetroForm
    {
        private ErrorLogs _errorLogs;
        public Parent()
        {
            _errorLogs = new ErrorLogs();
            InitializeComponent();
        }

        private void Parent_Load(object sender, EventArgs e)
        {
            try
            {
                this.Location = new Point(0, 0);
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                lblName.Text = "Welcome: " + GlobalVariables.glbName.ToString();
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("Parent", "Parent_Load", ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                lblTimer.Text = DateTime.Now.ToString("hh:mm:ss tt");
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("Parent", "timer1_Tick", ex.Message);
            }
        }

        private void invoiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                //this.IsMdiContainer = true;
                using (frmInvoice frmInv = new frmInvoice())
                {
                    frmInv.MdiParent = this.MdiParent;
                    frmInv.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("Parent", "invoiceToolStripMenuItem1_Click", ex.Message);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Login login = new Login();
                this.Enabled = false;
                login.Show();
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("Parent", "logoutToolStripMenuItem_Click", ex.Message);
            }
        }

        private void registrationToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmRegistration frmRgst = new frmRegistration())
                {
                    frmRgst.MdiParent = this.MdiParent;
                    frmRgst.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("Parent", "registrationToolStripMenuItem2_Click", ex.Message);
            }
        }

        private void Parent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void categoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Category category = new Category();
                category.MdiParent = this.MdiParent;
                category.ShowDialog();
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("Parent", "registrationToolStripMenuItem2_Click", ex.Message);
            }
        }

        private void subCategoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                using (Sub_Category subCategory = new Sub_Category())
                {
                    subCategory.MdiParent = this.MdiParent;
                    subCategory.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("Parent", "subCategoryToolStripMenuItem1_Click", ex.Message);
            }
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (Products product = new Products())
                {
                    product.MdiParent = this.MdiParent;
                    product.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("Parent", "productToolStripMenuItem_Click", ex.Message);
            }
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (Stocks stocks = new Stocks())
                {
                    stocks.MdiParent = this.MdiParent;
                    stocks.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("Parent", "registrationToolStripMenuItem_Click", ex.Message);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmStocks frmStock = new frmStocks())
                {
                    frmStock.MdiParent = this.MdiParent;
                    frmStock.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("Parent", "toolStripMenuItem1_Click", ex.Message);
            }
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("Notepad.exe");
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("Parent", "notepadToolStripMenuItem_Click", ex.Message);
            }
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("Calc.exe");
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("Parent", "calculatorToolStripMenuItem_Click", ex.Message);
            }
        }

        private void chartMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmChart frmChart = new frmChart())
                {
                    frmChart.MdiParent = this.MdiParent;
                    frmChart.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("Parent", "toolStripMenuItem1_Click", ex.Message);
            }
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
