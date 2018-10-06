using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class StockReport
    {
        public string ItemName { get; set; }
        public string CompanyName { get; set; }
        public decimal StockOutQty { get; set; }
        public decimal AvaliableQty { get; set; }
    }
}
