using System;
using System.Collections.Generic;

namespace Product_Management.Models
{
    public partial class Profit
    {
        public DateTime Date { get; set; }
        public int? TotalSales { get; set; }
        public int? TotalCost { get; set; }
        public int? Profit1 { get; set; }
    }
}
