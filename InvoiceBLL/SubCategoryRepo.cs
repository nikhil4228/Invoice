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
    public class SubCategoryRepo
    {

        string conStr = ConfigurationManager.AppSettings["conStr"].ToString();

        public DataTable GetAllCategories()
        {
            DataTable dtCat = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_getAllCategoriesDetails", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtCat);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return dtCat;
        }

        public int CreateSubCategory(string Name, string Description, int categoryId, byte[] Image,int CreatedBy)
        {
            int isInserted = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    using (SqlCommand cmd = new SqlCommand("Inv_CreateSubCategory", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Name", Name);
                        cmd.Parameters.Add("@Description", Description);
                        cmd.Parameters.Add("@CategoryId", categoryId);
                        cmd.Parameters.Add("@Image", Image);
                        cmd.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                       isInserted= cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return isInserted;
        }
        public DataTable GetAllSubCategory()
        {
            DataTable dtSubCat = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_GetAllSubCategories", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtSubCat);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return dtSubCat;
        }
    }
}
