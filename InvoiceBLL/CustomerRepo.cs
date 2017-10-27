using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace InvoiceBLL
{
    public class CustomerRepo
    {
        string conStr = ConfigurationManager.AppSettings["conStr"].ToString();
        public DataTable getAllCustomers()
        {
            DataTable dtAllCustomers = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_GetAllCustomers", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtAllCustomers);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return dtAllCustomers;
        }

        public int updateCustomer(string name,long mobile,string address,string email,int modifiedBy,int customerId)
        {
            int updated = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_UpdateCustomer", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NAME ",name);
                    cmd.Parameters.AddWithValue("@Mobile ",mobile);
                    cmd.Parameters.AddWithValue("@Address ",address);
                    cmd.Parameters.AddWithValue("@Email ",email);
                    cmd.Parameters.AddWithValue("@ModifiedBy ",modifiedBy);
                    cmd.Parameters.AddWithValue("@CustomerId ",customerId);
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

        public int deleteCustomer(int modifiedBy,int customerId)
        {
            int deleted = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_DeleteCustomerById", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ModifiedBy ", modifiedBy);
                    cmd.Parameters.AddWithValue("@CustomerId ", customerId);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    deleted = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return deleted;
        }

        public DataTable getCustomerById(int customerId)
        {
            DataTable dtCustomer = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_GetCustomerbyId", con);
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtCustomer);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return dtCustomer;
        }

        public int checkIfCustomerExist(long mobile)
        {
            int isUserExist = 0;
            return isUserExist;
        }
    }
}
