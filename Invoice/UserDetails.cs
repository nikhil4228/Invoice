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
    public partial class UsersDetails : MetroForm
    {
        private UserRepo _objUser;
        private UserTypeRepo _objUserType;
        public static int selectedUserId;
        public UsersDetails()
        {
            InitializeComponent();
            _objUser = new UserRepo();
            _objUserType = new UserTypeRepo();
        }

        private void UsersDetails_Load(object sender, EventArgs e)
        {
            loadAllData();
        }
        public void loadAllData()
        {
            loadDropDown();
            loadGrid();
        }
        public void loadGrid()
        {
            try
            {
                DataTable dtUsers = new DataTable();
                dtUsers = _objUser.GetAllUsers();
                if (dtUsers != null)
                {
                    dataGridView1.DataSource = dtUsers;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void loadDropDown()
        {
            DataTable dtUserType = new DataTable();
            try
            {
                dtUserType = _objUserType.GetUserTypes();
                DataRow dr = dtUserType.NewRow();
                dr["UserType"] = "SELECT(Display ALL)";
                dr["UserTypeId"] = 0;
                dtUserType.Rows.InsertAt(dr, 0);
                if (dtUserType != null)
                {
                    cbUserType.DataSource = dtUserType;
                    cbUserType.ValueMember = "UserTypeId";
                    cbUserType.DisplayMember = "UserType";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void cbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //code to display users depending on the role selected
            if (cbUserType.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    if (cbUserType.SelectedValue.ToString() == "0")
                    {
                        loadGrid();
                    }
                    else if  (Convert.ToInt32(cbUserType.SelectedValue)>0)
                    {
                        dataGridView1.DataSource = _objUser.GetAllUsersByRole(Convert.ToInt32(cbUserType.SelectedValue));
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }           
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedUserId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString());
            try
            {
                if (e.ColumnIndex == 0)
                {
                    //Edit goes here 
                    using (UpdateUserDetails updateUserDetails = new UpdateUserDetails())
                    {
                        updateUserDetails.MdiParent = this.MdiParent;
                        updateUserDetails.ShowDialog();
                        loadAllData();
                    }
                    // MessageBox.Show("0 is the colindex" + "------------------" + selectedUserId);
                }
                else if (e.ColumnIndex == 1)
                {
                    //delete with pop up goes here 
                    DialogResult dialouge = MessageBox.Show("Are You Sure you want to DELETE !", "ALERT", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (dialouge == DialogResult.Yes)
                    {
                        //Delete the item this returns us the ststus if the item is deleted or no IF the status returned is 0 that means the category is deleted else there are other products that belong to the category
                        int deletedStatus = _objUser.DeleteUser(selectedUserId, GlobalVariables.glbUserId);
                        if (deletedStatus >0)
                        {
                            MessageBox.Show("The User is deleted successfully", "Alert", MessageBoxButtons.OK);
                            loadAllData();
                        }
                    }
                    else if (dialouge == DialogResult.No)
                    {
                    }
                    //MessageBox.Show("1 is the colindex");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
