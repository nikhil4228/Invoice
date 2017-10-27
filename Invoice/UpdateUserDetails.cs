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
using Invoice.Helper;

namespace Invoice
{
    public partial class UpdateUserDetails : MetroForm
    {
        private UserRepo _objUser;
        private UserTypeRepo _objUserType;
        private Cryptography _objCrypto;
        public int userId = UsersDetails.selectedUserId;
        public UpdateUserDetails()
        {
            InitializeComponent();
            _objUser = new UserRepo();
            _objUserType = new UserTypeRepo();
            _objCrypto = new Cryptography();
            loadUserType();

        }
        public void loadUserType()
        {
            try
            {
                DataTable dtUserType = new DataTable();
                dtUserType = _objUserType.GetUserTypes();
                cmbUserType.DataSource = dtUserType;
                cmbUserType.ValueMember = "UserTypeId";
                cmbUserType.DisplayMember = "UserType";
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void bindRetreivedData()
        {
            try
            {
                DataTable dtUserDetails = _objUser.GetUserDetailsById(userId);
                if (dtUserDetails != null)
                {
                    string name = dtUserDetails.Rows[0]["Name"].ToString();
                    int userType = Convert.ToInt32(dtUserDetails.Rows[0]["Role"]);
                    string userName = dtUserDetails.Rows[0]["UserName"].ToString();
                    string contactNo = dtUserDetails.Rows[0]["Mobile"].ToString();
                    string email = dtUserDetails.Rows[0]["Email"].ToString();
                    string password = _objCrypto.Decrypt(dtUserDetails.Rows[0]["Password"].ToString());

                    txtName.Text = name;
                    cmbUserType.SelectedValue = userType;
                    txtUsername.Text = userName;
                    txtPassword.Text = password;
                    txtContact_no.Text = contactNo;
                    txtEmail_Address.Text = email;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void UpdateUserDetails_Load(object sender, EventArgs e)
        {
            loadUserType();
            bindRetreivedData();
        }

        private void btnUpdate_record_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int userType = Convert.ToInt32(cmbUserType.SelectedValue);
            string userName = txtUsername.Text;
            string contactNo = txtContact_no.Text;
            string email = txtEmail_Address.Text;
            string password = _objCrypto.Encrypt(txtPassword.Text);
            try
            {
                int updated = _objUser.UpdateUserDetails(userId, userName, password, userType, name, contactNo, email, GlobalVariables.glbUserId);
                MessageBox.Show("User Updated Successfully");
                this.Hide();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    string name = txtName.Text;
        //    int userType = Convert.ToInt32(cmbUserType.SelectedValue);
        //    string userName = txtUsername.Text;
        //    string contactNo = txtContact_no.Text;
        //    string email = txtEmail_Address.Text;
        //    string password = _objCrypto.Encrypt(txtPassword.Text);
        //    try
        //    {
        //        int updated = _objUser.UpdateUserDetails(userId, userName, password, userType, name, contactNo, email, DateTime.Now, GlobalVariables.glbUserId);
        //        MessageBox.Show("User Updated Successfully");
        //        this.Hide();
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //}
    }
}
