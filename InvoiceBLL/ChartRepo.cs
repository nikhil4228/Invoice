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
    public class ChartRepo
    {
        string conStr = ConfigurationManager.AppSettings["conStr"].ToString();
        public DataTable getCustomerChart()
        {
            DataTable dtCustomerChart = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_CustomerChart", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtCustomerChart);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return dtCustomerChart;
        }
        public DataTable getStockChart()
        {
            DataTable dtStockChart = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_StockChart", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtStockChart);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return dtStockChart;
        }

        public DataTable getSalesChart()
        {
            DataTable dtSalesChart = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand("Inv_SalesChart", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtSalesChart);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return dtSalesChart;
        }
    }
}
