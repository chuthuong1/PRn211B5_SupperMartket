using System;
using System.Collections.Generic;

namespace Product_Management.Models
{
    public partial class TransactionDetail
    {
        public int TransactionId { get; set; }
        public int ProductId { get; set; }
        public int? Quantity { get; set; }
        public int Price { get; set; }

        public virtual Product Product { get; set; } = null!;
    }
}
