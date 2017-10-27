using Invoice.Helper;
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
    public partial class Print : Form
    {
        private ErrorLogs _errorLogs;
        public Print()
        {
            _errorLogs = new ErrorLogs();
            InitializeComponent();
        }
        private void Print_Load(object sender, EventArgs e)
        {
            try
            {
                lblInvoiceDate.Text = System.DateTime.Now.ToShortDateString();
                dgvInvoice.Columns["Status"].Visible = false;
                StrikeOutInActiveProduct();
                //Add a Panel control.
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("Print", "Print_Load", ex.Message);
            }
        }
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;
        private void CaptureScreen()
        {
            try
            {
                Graphics mygraphics = this.CreateGraphics();
                Size s = this.Size;
                memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
                Graphics memoryGraphics = Graphics.FromImage(memoryImage);
                IntPtr dc1 = mygraphics.GetHdc();
                IntPtr dc2 = memoryGraphics.GetHdc();
                BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
                mygraphics.ReleaseHdc(dc1);
                memoryGraphics.ReleaseHdc(dc2);
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("Print", "CaptureScreen", ex.Message);
            }
        }

        private void StrikeOutInActiveProduct()
        {
            try
            {
                if (dgvInvoice.Rows.Count > 0)
                {
                    for (int i = 0; i < this.dgvInvoice.Rows.Count; i++)
                    {
                        if (dgvInvoice.Rows[i].Cells["Status"].Value.ToString() == "False")
                        {
                            dgvInvoice.Rows[i].DefaultCellStyle.Font = new Font(dgvInvoice.Font.OriginalFontName, 9, FontStyle.Strikeout);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmInvoice", "StrikeOutInActiveProduct", ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnPrint.Hide();
                CaptureScreen();
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("Print", "button1_Click", ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                CaptureScreen();
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("Print", "button1_Click", ex.Message);
            }
        }

        private void Print_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnPrint.PerformClick();
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("Print", "Print_KeyDown", ex.Message);
            }
        }
    }
}
