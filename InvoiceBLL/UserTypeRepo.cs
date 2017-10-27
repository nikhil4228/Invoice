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
    public class UserTypeRepo
    {
        string conStr = ConfigurationManager.AppSettings["conStr"].ToString();
        public DataTable GetUserTypes()
        {
            DataTable dtUserTypes = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter("Inv_getUserTypes",con))
                    {
                        da.Fill(dtUserTypes);
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return dtUserTypes;
        }
    }
}
