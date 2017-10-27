using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace InvoiceBLL
{
    public class ProductRepo
    {
        string conStr = ConfigurationManager.AppSettings["conStr"].ToString();

        public DataTable GetAllCategories()
        {
            DataTable dtCategory = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_getAllCategoriesDetails", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtCategory);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return dtCategory;
        }

        public DataTable getCategories()
        {
            DataTable dtCategory = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_getCategories", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtCategory);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return dtCategory;
        }

        public DataTable GetSubCategoriesByCatId(int categoryId)
        {
            DataTable dtSubCategory = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_getSubCategoriesBycatId", con);
                    cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtSubCategory);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return dtSubCategory;
        }

        public DataTable GetAllProducts()
        {
            DataTable dtproducts = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_GetAllProducts", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtproducts);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return dtproducts;
        }

        public DataTable GetProductById(Int64 ProductId)
        {
            DataTable dtproduct = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_GetProductById", con);
                    cmd.Parameters.AddWithValue("@id", ProductId);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtproduct);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return dtproduct;
        }

        public int insertProduct(string strProductName, int CategoryId, int SubCategoryId, decimal OriginalPrice, int Discount, decimal CGST, decimal SGST, decimal Price, string strProductDescription, byte[] Image, int CreatedBy)
        {
            int isInserted = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    using (SqlCommand cmd = new SqlCommand("Inv_CreateProduct", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", strProductName);
                        cmd.Parameters.AddWithValue("@CategoryId", CategoryId);
                        cmd.Parameters.AddWithValue("@SubCategoryId", SubCategoryId);
                        cmd.Parameters.AddWithValue("@OriginalPrice", OriginalPrice);
                        cmd.Parameters.AddWithValue("@Discount", Discount);
                        cmd.Parameters.AddWithValue("@CGST", CGST);
                        cmd.Parameters.AddWithValue("@SGST", SGST);
                        cmd.Parameters.AddWithValue("@Price", Price);
                        cmd.Parameters.AddWithValue("@Description", strProductDescription);
                        cmd.Parameters.AddWithValue("@Image", (Image == null) ? (object)DBNull.Value : Image).SqlDbType = SqlDbType.Image;
                        cmd.Parameters.AddWithValue("@CreatedBy", CreatedBy);
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

        public DataTable GetAllProduct()
        {
            DataTable dtproduct = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_GetAllProduct", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtproduct);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return dtproduct;
        }

        public int updateProduct(int ProductId ,string updatedName,string updatedDescription , double updatedOriginalPrice,double updatedCGST ,double updatedSGST,double updatedDiscount,byte[] image,int updatedCategoryId ,int updatedSubCategoryId ,double updatedPrice,int updatedModifiedBy)
        { 
            int updated = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    using (SqlCommand cmd = new SqlCommand("Inv_UpdateProduct", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name ", updatedName);
                        cmd.Parameters.AddWithValue("@Description ",updatedDescription);
                        cmd.Parameters.AddWithValue("@OriginalPrice ",updatedOriginalPrice);
                        cmd.Parameters.AddWithValue("@CGST ",updatedCGST);
                        cmd.Parameters.AddWithValue("@SGST ",updatedSGST);
                        cmd.Parameters.AddWithValue("@Discount",updatedDiscount);
                        cmd.Parameters.AddWithValue("@Img", (image == null) ? (object)DBNull.Value : image).SqlDbType = SqlDbType.Image;
                        cmd.Parameters.AddWithValue("@CategoryId ",updatedCategoryId);
                        cmd.Parameters.AddWithValue("@SubCategoryId ",updatedSubCategoryId);
                        cmd.Parameters.AddWithValue("@Price ",updatedPrice);
                        cmd.Parameters.AddWithValue("@ModifiedBy",updatedModifiedBy);
                        cmd.Parameters.AddWithValue("@ProductId",ProductId);
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

        public int deleteProductById(int productId,int userId)
        {
            int deleted = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_DeleteProductById", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductId", productId);
                    cmd.Parameters.AddWithValue("@ModifiedBy", userId);
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
        
        public DataTable GetAllProductsByCategory(int CategoryId)
        {
            DataTable dtProducts = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_GetAllProductsByCategory", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@categoryId", CategoryId);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtProducts);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return dtProducts;
        }
    }
}
