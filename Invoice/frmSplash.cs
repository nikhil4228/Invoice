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
    public partial class frmSplash : Form
    {
        Timer tmr;
        private ErrorLogs _errorLogs;
        public frmSplash()
        {
            _errorLogs = new ErrorLogs();
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void frmSplash_Shown(object sender, EventArgs e)
        {
            try
            {
                tmr = new Timer();
                //set time interval 3 sec
                tmr.Interval = 100;
                //starts the timer
                tmr.Start();
                tmr.Tick += tmr_Tick;
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmSplash", "frmSplash_Shown", ex.Message);
            }

        }
        void tmr_Tick(object sender, EventArgs e)
        {
            try
            {
                //display mainform
                Login frmLogin = new Login();
                progressBar1.Visible = true;
                this.progressBar1.Value = this.progressBar1.Value + 2;
                if (this.progressBar1.Value == 10)
                {
                    label3.Text = "Reading modules..";
                }
                else if (this.progressBar1.Value == 20)
                {
                    label3.Text = "Turning on modules.";
                }
                else if (this.progressBar1.Value == 40)
                {
                    label3.Text = "Starting modules..";
                }
                else if (this.progressBar1.Value == 60)
                {
                    label3.Text = "Loading modules..";
                }
                else if (this.progressBar1.Value == 80)
                {
                    label3.Text = "Done Loading modules..";
                }
                else if (this.progressBar1.Value == 100)
                {
                    //after 3 sec stop the timer
                    tmr.Stop();
                    frmLogin.Show();
                    //hide this form
                    this.Hide();
                    timer1.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmSplash", "tmr_Tick", ex.Message);
            }
        }
    }
}
