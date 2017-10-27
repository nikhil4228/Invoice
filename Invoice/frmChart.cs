using Invoice.Helper;
using InvoiceBLL;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice
{
    public partial class frmChart : MetroForm
    {
        private ErrorLogs _errorLogs;
        private ChartRepo _repoChart;
        public frmChart()
        {
            _errorLogs = new ErrorLogs();
            _repoChart = new ChartRepo();
            InitializeComponent();
        }

        private void frmChart_Load(object sender, EventArgs e)
        {
            try
            {
                fillCustomerChart();
                fillStockChart();
                //sales per month
            }
            catch (Exception ex)
            {

            }
        }

        //fillCustomerChart method  
        private void fillCustomerChart()
        {
            try
            {
                DataTable dtCustomerChart = _repoChart.getCustomerChart();
                chartCustomer.DataSource = dtCustomerChart;
                chartCustomer.Series.Add("Price");
                chartCustomer.Name = "Price";
                //set the member of the chart data source used to data bind to the X-values of the series  
                chartCustomer.Series["Price"].XValueMember = "Name";
                //set the member columns of the chart data source used to data bind to the X-values of the series  
                chartCustomer.Series["Price"].YValueMembers = "Price";
                chartCustomer.Titles.Add("Customer Report Chart");
            }
            catch (Exception ex)
            {

                _errorLogs.LogErrors("frmChart", "fillCustomerChart", ex.Message);
            }
        }

        //fillStockChart method  
        private void fillStockChart()
        {
            try
            {
                DataTable dtStockChart = _repoChart.getStockChart();
                chartStock.DataSource = dtStockChart;
                chartStock.Series.Add("Qty");
                chartStock.Name = "Qty";
                //set the member of the chart data source used to data bind to the X-values of the series  
                chartStock.Series["Qty"].XValueMember = "Name";
                //set the member columns of the chart data source used to data bind to the X-values of the series  
                chartStock.Series["Qty"].YValueMembers = "Qty";

                //3 Deimension Value
                //chartStock.ChartAreas[0].AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
                //chartStock.ChartAreas[0].AxisY2.Title = "tets";
                //chartStock.Titles.Add("Stock Report Chart");
                //chartStock.ChartAreas[0].AxisY2.Minimum = 0;
                //chartStock.ChartAreas[0].AxisY2.Maximum = 100;
                //chartStock.ChartAreas[0].AxisY2.Interval = 10;
            }
            catch (Exception ex)
            {
                _errorLogs.LogErrors("frmChart", "fillStockChart", ex.Message);

            }
        }
    }
}
