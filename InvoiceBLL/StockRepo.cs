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
    public class StockRepo
    {
        string conStr = ConfigurationManager.AppSettings["conStr"].ToString();
        public Int64 getProductStockCount(Int64 ProductId)
        {
            DataTable dtStocks = new DataTable();
            Int64 count = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_getProductStockCount", con);
                    cmd.Parameters.AddWithValue("@ProductId", ProductId);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtStocks);
                    if (dtStocks != null && dtStocks.Rows.Count > 0 && dtStocks.Rows[0] != null)
                    {
                        count = Convert.ToInt64(dtStocks.Rows[0]["Quantity"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return count;
        }

        public int UpdateInsertStock(long ProductId, string Feature, int Qty, string StockDate, int CreatedBy)
        {
            int isUpdated = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_UpdateInsertStock", con);
                    cmd.Parameters.AddWithValue("@ProductId", ProductId);
                    cmd.Parameters.AddWithValue("@Feature", Feature);
                    cmd.Parameters.AddWithValue("@Qty", Qty);
                    cmd.Parameters.AddWithValue("@StockDate", StockDate);
                    cmd.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    isUpdated = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return isUpdated;
        }

        public int UpdateReturnStock(DataTable dtStockDetails, long InvoiceNo, string Type, int CreatedBy)
        {
            int isUpdated = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_CancelReturnStockUpdate", con);
                    cmd.Parameters.AddWithValue("@StockDetails_Type", dtStockDetails);
                    cmd.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                    cmd.Parameters.AddWithValue("@InvoiceNo", InvoiceNo);
                    cmd.Parameters.AddWithValue("@Type", Type);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    isUpdated = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return isUpdated;
        }

        public DataTable getAllStocks()
        {
            DataTable dtStock = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_getAllStocks", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtStock);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return dtStock;
        }

        public DataTable getAllCategories()
        {
            DataTable dtCategories = new DataTable();
            try
            {                
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_getCategories", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtCategories);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return dtCategories;
        }

        public DataTable getAllStocksByCategory(int CategoryId)
        {
            DataTable dtStocks = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_getAllStocksByCategoryId", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CategoryId", CategoryId);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtStocks);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return dtStocks;
        }

        public DataTable getStockDetails(int productId)
        {
            
            DataTable dtStockDetails = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_GetStockDetailsByProductId",con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@productId", productId);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtStockDetails);
                }
                return dtStockDetails;

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
