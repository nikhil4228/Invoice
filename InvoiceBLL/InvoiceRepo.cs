using InvoiceBLL.Model;
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
    public class InvoiceRepo
    {
        string conStr = ConfigurationManager.AppSettings["conStr"].ToString();
        public Int64 getInvoiceIdentity()
        {
            DataTable dtInvoice = new DataTable();
            Int64 InvoiceNo = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_getInvoiceIdentity", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtInvoice);
                    if (dtInvoice != null && dtInvoice.Rows.Count > 0 && dtInvoice.Rows[0] != null)
                    {
                        InvoiceNo = Convert.ToInt64(dtInvoice.Rows[0]["InvoiceNo"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return InvoiceNo;
        }

        public bool CreateInvoiceRecord(InvoiceViewModel invoice, DataTable dtInvoiceDetails)
        {
            bool isCreated = false;
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_InsertInvoice", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter prmInvoiceDt = cmd.Parameters.AddWithValue("@InvoiceDetails_Type", dtInvoiceDetails);
                    prmInvoiceDt.SqlDbType = SqlDbType.Structured;
                    cmd.Parameters.AddWithValue("@InvoiceNo", invoice.InvoiceNo);
                    cmd.Parameters.AddWithValue("@InvoiceDate", invoice.InvoiceDate);
                    cmd.Parameters.AddWithValue("@SubTotal", invoice.SubTotal);
                    cmd.Parameters.AddWithValue("@Discount", invoice.Discount);
                    cmd.Parameters.AddWithValue("@DiscountAmt", invoice.DiscountAmt);
                    cmd.Parameters.AddWithValue("@GrandTotal", invoice.GrandTotal);
                    cmd.Parameters.AddWithValue("@Cash", invoice.Cash);
                    cmd.Parameters.AddWithValue("@CustName", invoice.CustomerName);
                    cmd.Parameters.AddWithValue("@Mobile", invoice.CustomerMobile);
                    cmd.Parameters.AddWithValue("@Address", invoice.CustomerAddress);
                    cmd.Parameters.AddWithValue("@Email", invoice.CustomerEmail);
                    cmd.Parameters.AddWithValue("@Notes", invoice.Notes);
                    cmd.Parameters.AddWithValue("@CreatedBy", invoice.CreatedBy);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd.ExecuteNonQuery();
                    isCreated = true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return isCreated;
        }

        public DataSet GetInVoiceDetails(long InvoiceNo)
        {
            DataSet dsInvoice = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_GetInvoiceDetailsBYInvoiceNo", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@InvoiceNo", InvoiceNo);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dsInvoice);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return dsInvoice;
        }

        public DataTable GetInVoiceDetailsByCustomerId(int CustomerId)
        {
            DataTable dtInvoiceDetails = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_GetInvoiceDetailsByCustomerId", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CustomerId", CustomerId);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtInvoiceDetails);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return dtInvoiceDetails;
        }

        public DataTable GetCompleteDetailsPurchased(int invoiceNo)
        {
            DataTable dtProductDetails = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_GetCompleteDetailsPurchased", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@InvoiceNo", invoiceNo);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtProductDetails);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return dtProductDetails;
        }
    }
}
