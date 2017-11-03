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
    public class OrdersRepo
    {
        string conStr = ConfigurationManager.AppSettings["conStr"].ToString();
        public DataTable getAllOrders()
        {
            DataTable dtOrders = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_GetAllOrders", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtOrders);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return dtOrders;
        }

        public DataTable getAllOrdersByFilters(int invoiceNo,int userId,string paymentMode,string invoiceDate,long customerMobileNo)
        {
            DataTable dtOrders = new DataTable();
            try
            {
                //Inv_GetInvoiceDetailsByFilters
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_GetInvoiceDetailsByFilters", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@invoiceNo",invoiceNo);
                    cmd.Parameters.AddWithValue("@UserId",userId);
                    cmd.Parameters.AddWithValue("@paymentMode",paymentMode);
                    cmd.Parameters.AddWithValue("@invoiceDate",invoiceDate);
                    cmd.Parameters.AddWithValue("@customerMobileno",customerMobileNo);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtOrders);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return dtOrders;
        }

        public DataTable getOrderDetails(int invoiceNumber)
        {
            DataTable dtOrderDetails = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_GetOrderDetailsByInvoiceId", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@InvoiceNo", invoiceNumber);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtOrderDetails);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return dtOrderDetails;
        }
    }
}
