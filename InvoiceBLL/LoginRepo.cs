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
    public class LoginRepo
    {
        string conStr = ConfigurationManager.AppSettings["conStr"].ToString();
        public DataTable ValidateUser(string userName, string Password)
        {
            DataTable dtUsers = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_CheckUserExists", con);
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtUsers);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return dtUsers;
        }
        public int RegisterUser(string UserName, string Password, int UserType, string Name, string ContactNo, string Email)
        {
            int isInserted = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_RegisterUser", con);
                    cmd.Parameters.AddWithValue("@UserName", UserName);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@UserType", UserType);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Mobile", ContactNo);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.CommandType = CommandType.StoredProcedure;
                   if(con.State==ConnectionState.Closed)
                   {
                       con.Open();
                   }
                   isInserted = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return isInserted;
        }
    }
}
