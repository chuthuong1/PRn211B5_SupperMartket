using System;
using System.Collections.Generic;

namespace Product_Management.Models
{
    public partial class Profit
    {
        public DateTime Date { get; set; }
        public decimal? TotalSales { get; set; }
        public decimal? TotalCost { get; set; }
        public decimal? Profit1 { get; set; }

        public virtual Invoice DateNavigation { get; set; } = null!;
    }
}
