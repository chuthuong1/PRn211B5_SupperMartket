using System;
using System.Collections.Generic;

namespace Product_Management.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            ImportGoods = new HashSet<ImportGood>();
        }

        public int SupplierId { get; set; }
        public string? SupplierName { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }

        public virtual ICollection<ImportGood> ImportGoods { get; set; }
    }
}
