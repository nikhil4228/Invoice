using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceBLL.Model
{
    public class InvoiceViewModel
    {
        public long InvoiceNo { get; set; }
        public string InvoiceDate { get; set; }
        public decimal SubTotal { get; set; }
        public int Discount { get; set; }
        public decimal DiscountAmt { get; set; }
        public decimal GrandTotal { get; set; }
        public string Cash { get; set; }
        public string Notes { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public long CustomerMobile { get; set; }
        public string CustomerEmail { get; set; }
        public int CreatedBy { get; set; }
    }
}
