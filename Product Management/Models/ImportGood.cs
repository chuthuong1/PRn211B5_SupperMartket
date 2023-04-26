using System;
using System.Collections.Generic;

namespace Product_Management.Models
{
    public partial class ImportGood
    {
        public int ImportId { get; set; }
        public int? ProductId { get; set; }
        public int? SupplierId { get; set; }
        public DateTime? Date { get; set; }
        public int? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }

        public virtual Product? Product { get; set; }
        public virtual Supplier? Supplier { get; set; }
    }
}
