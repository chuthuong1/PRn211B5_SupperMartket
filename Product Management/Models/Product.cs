using System;
using System.Collections.Generic;

namespace Product_Management.Models
{
    public partial class Product
    {
        public Product()
        {
            ImportGoods = new HashSet<ImportGood>();
            Losses = new HashSet<Loss>();
            TransactionDetails = new HashSet<TransactionDetail>();
        }

        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public int? CategoryId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? SellingPrice { get; set; }
        public int? Quantity { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<ImportGood> ImportGoods { get; set; }
        public virtual ICollection<Loss> Losses { get; set; }
        public virtual ICollection<TransactionDetail> TransactionDetails { get; set; }
    }
}
