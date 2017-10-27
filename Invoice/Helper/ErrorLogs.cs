using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.Helper
{
    public class ErrorLogs
    {
        string conStr = ConfigurationManager.AppSettings["conStr"].ToString();
        public void LogErrors(string Module, string Method, string error)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_LogErros", con);
                    cmd.Parameters.AddWithValue("@Module", Module);
                    cmd.Parameters.AddWithValue("@Method", Method);
                    cmd.Parameters.AddWithValue("@Error", error);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
