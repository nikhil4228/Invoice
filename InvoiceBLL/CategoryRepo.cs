using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace InvoiceBLL
{
    public class CategoryRepo
    {
        string conStr = ConfigurationManager.AppSettings["conStr"].ToString();
        public int CreateCategory(string Name, string Description, byte[] Image,int CreatedBy)
        {
            int isInserted = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    using (SqlCommand cmd = new SqlCommand("Inv_CreateCategory", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", Name);
                        cmd.Parameters.AddWithValue("@Description", Description);
                        cmd.Parameters.AddWithValue("@Image", (Image == null) ? (object)DBNull.Value : Image).SqlDbType = SqlDbType.Image;
                        cmd.Parameters.AddWithValue("@CreatedBy",CreatedBy);
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        isInserted = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return isInserted;
        }

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

        //ADDED BY ME FOR CATEGORY UPDATE
        public int UpdateCategory(string Name, string Description, byte[] Image, int ModifiedBy, int CategoryId)
        {
            int updated = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    using (SqlCommand cmd = new SqlCommand("Inv_UpdateCategory", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name ", Name);
                        cmd.Parameters.AddWithValue("@Description", Description);
                        cmd.Parameters.AddWithValue("@Image", (Image == null) ? (object)DBNull.Value : Image).SqlDbType = SqlDbType.Image;
                        cmd.Parameters.AddWithValue("@ModifiedBY ", ModifiedBy);
                        cmd.Parameters.AddWithValue("@CategoryId ", CategoryId);
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        updated = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return updated;
        }

        public DataTable GetCategoryById(int categoryId)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    using (SqlCommand cmd = new SqlCommand("Inv_GetCategoryById",con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CategoryId",categoryId);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        //if (con.State == ConnectionState.Closed)
                        //{
                        //    con.Open();
                        //}
                        //SqlDataReader dr = cmd.ExecuteReader();
                        //while (dr.Read())
                        //{
                        //    DataRow dataRow = dt.NewRow();
                        //    dataRow[0]= dr["Name"].ToString();
                        //    dataRow[1]= dr["Description"].ToString();
                        //    dataRow[2] = dr["Image"] ;
                        //    dt.Rows.Add(dataRow);
                        //}
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return dt;
        }

        public int DeleteCategoryById(int categoryId,int modifiedUserID)
        {
            int deleted = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_DeleteCategoryById", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@categoryId", categoryId);
                    cmd.Parameters.AddWithValue("@modifiedBy", modifiedUserID);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        deleted = Convert.ToInt32(dr[0]);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return deleted;
        }
    }
}
