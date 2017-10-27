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
using MessageBoxExample;
using InvoiceBLL;
using Invoice.Helper;

namespace Invoice
{
    public partial class Login : MetroForm
    {
        private ErrorLogs _errorLogs;
        private LoginRepo _repoLogin;
        private Cryptography _crypt;
        public Login()
        {
            //
            _errorLogs = new ErrorLogs();
            _repoLogin = new LoginRepo();
            _crypt = new Cryptography();
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Guid obj = Guid.NewGuid();
            //Guid id = Guid.NewGuid();
            //String guid = Guid.NewGuid().ToString();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text != string.Empty && txtPassword.Text != string.Empty)
                {

                    string strUserName = txtUserName.Text;
                    string strPassword = _crypt.Encrypt(txtPassword.Text);
                    DataTable dtUsers = _repoLogin.ValidateUser(strUserName, strPassword);
                    if (dtUsers != null && dtUsers.Rows.Count > 0)
                    {
                        GlobalVariables.glbUserId = Convert.ToInt32(dtUsers.Rows[0]["UserId"].ToString());
                        GlobalVariables.glbName = dtUsers.Rows[0]["Name"].ToString();
                        GlobalVariables.glbroleId = Convert.ToInt32(dtUsers.Rows[0]["UserType"].ToString());
                        lblNotify.Visible = false;
                        if (Convert.ToString(dtUsers.Rows[0]["UserType"]) == "1")
                        {
                            this.Hide();
                            using (Parent frmParent = new Parent())
                            {
                                frmParent.ShowDialog();
                            }
                            this.Close();
                        }
                        else if (Convert.ToString(dtUsers.Rows[0]["UserType"]) == "2")
                        {
                            this.Hide();
                            using (Parent frmParent = new Parent())
                            {
                                frmParent.invoiceToolStripMenuItem.Visible = false;
                                //frmParent.OrderToolStripMenuItem.Visible = false;
                                frmParent.usersToolStripMenuItem.Visible = false;
                                frmParent.reportsToolStripMenuItem.Visible = false;
                                frmParent.stockMenuItem.Visible = false;
                                frmParent.registrationToolStripMenuItem2.Visible = false;
                                frmParent.chartMenuItem.Visible = false;
                                frmParent.ShowDialog();
                            }
                            this.Close();
                        }
                    }
                    else
                    {
                        lblNotify.Text = ".. Invalid user!";
                        lblNotify.Visible = true;
                        txtPassword.Clear();
                    }
                }
                else
                {
                    lblNotify.Text = "Please Enter Username && password";
                    lblNotify.Visible = true;
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("Login", "btnLogin_Click", ex.Message);
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnLogin.PerformClick();
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("Login", "txtPassword_KeyDown", ex.Message);
            }
        }
    }
}
