using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceBLL
{
    public class UserRepo
    {
        string conStr = ConfigurationManager.AppSettings["conStr"].ToString();

        public DataTable GetAllUsers()
        {
            DataTable dtUsers = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_GetAllUsers", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtUsers);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return dtUsers;
        }

        public DataTable GetUserDetailsById(int userId)
        {
            DataTable dtUserDetails = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_GetUserDetailsById", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userId", userId);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtUserDetails);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return dtUserDetails;
        }

        public int UpdateUserDetails(int userId,string userName,string password,int userType,string name,string mobile,string email,int modifiedBy)
        {
            int updated = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_UpdateUserById", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserId",userId);
                    cmd.Parameters.AddWithValue("@UserName",userName);
                    cmd.Parameters.AddWithValue("@Password",password);
                    cmd.Parameters.AddWithValue("@UserType",userType);
                    cmd.Parameters.AddWithValue("@Name",name);
                    cmd.Parameters.AddWithValue("@Mobile",mobile);
                    cmd.Parameters.AddWithValue("@Email",email);
                    cmd.Parameters.AddWithValue("@ModifiedBy", modifiedBy);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    updated = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return updated;
        }

        public int DeleteUser(int userId,int modifiedBy)
        {
            int deleted = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_DeleteUser", con);
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@ModifiedBy", modifiedBy);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd.CommandType = CommandType.StoredProcedure;
                    deleted = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return deleted;
        }

        public DataTable GetAllUsersByRole(int roleId)
        {
            DataTable dtUsers = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_GetAllUsersByRole", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RoleId", roleId);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtUsers);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return dtUsers;
        }
    }
}
