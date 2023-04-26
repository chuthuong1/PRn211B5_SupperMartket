using System;
using System.Collections.Generic;

namespace Product_Management.Models
{
    public partial class Loss
    {
        public int LossId { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public string? Reason { get; set; }
        public DateTime? Date { get; set; }

        public virtual Product? Product { get; set; }
    }
}
