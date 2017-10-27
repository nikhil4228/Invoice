using Invoice.Helper;
using InvoiceBLL;
using MessageBoxExample;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice
{
    public partial class frmRegistration : MetroForm
    {
        private ErrorLogs _errorLogs;
        private UserTypeRepo _userTypeRepo;
        private LoginRepo _repoLogin;
        private Cryptography _crypt;
        public frmRegistration()
        {
            _errorLogs = new ErrorLogs();
            _userTypeRepo = new UserTypeRepo();
            _repoLogin = new LoginRepo();
            _crypt = new Cryptography();
            InitializeComponent();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            try
            {
                bindUserType();
                txtName.Focus();
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmRegistration", "frmRegistration_Load", ex.Message);
            }
        }

        private void bindUserType()
        {
            try
            {
                DataTable dtUserType = _userTypeRepo.GetUserTypes();
                if (dtUserType != null)
                {
                    cmbUserType.DataSource = dtUserType;
                    cmbUserType.ValueMember = "UserTypeId";
                    cmbUserType.DisplayMember = "UserType";
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmRegistration", "bindUserType", ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmRegistration", "btnDelete_Click", ex.Message);
            }
        }

        private void btnUpdate_record_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmRegistration", "btnDelete_Click", ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == string.Empty)
                {
                    MyMessageBox.ShowBox("Name is required!", "Alert!");
                    return;
                }
                else if (txtUsername.Text == string.Empty)
                {
                    MyMessageBox.ShowBox("UserName is required!", "Alert!");
                    return;
                }
                else if (txtPassword.Text == string.Empty)
                {
                    MyMessageBox.ShowBox("Password is required!", "Alert!");
                    return;
                }
                else
                {
                    string Name = txtName.Text;
                    string UserName = txtUsername.Text;
                    string Password = _crypt.Encrypt(txtPassword.Text);
                    int UserType = Convert.ToInt32(cmbUserType.SelectedValue);
                    string ContactNo = txtContact_no.Text;
                    string Email = txtEmail_Address.Text;
                    int i = _repoLogin.RegisterUser(UserName, Password, UserType, Name, ContactNo, Email);
                    if (i > 0)
                    {
                        MyMessageBox.ShowBox("User Created!", "Success!");
                        txtName.Clear();
                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtContact_no.Clear();
                        txtEmail_Address.Clear();
                    }
                    else
                    {
                        MyMessageBox.ShowBox("UserName already Exists!", "Failed!");
                    }
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmRegistration", "btnRegister_Click", ex.Message);
            }
        }

        private void txtEmail_Address_Leave(object sender, EventArgs e)
        {
            try
            {
                Regex rEMail = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
                if (txtEmail_Address.Text.Length > 0)
                {
                    if (!rEMail.IsMatch(txtEmail_Address.Text))
                    {
                        MyMessageBox.ShowBox("Invalid Email Address!", "Alert!");
                        txtEmail_Address.Clear();
                        txtEmail_Address.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmRegistration", "txtEmail_Address_Leave", ex.Message);
            }
        }
    }
}
