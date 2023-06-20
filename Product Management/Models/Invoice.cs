using System;
using System.Collections.Generic;

namespace Product_Management.Models
{
    public partial class Invoice
    {
        public Invoice()
        {
            TransactionDetails = new HashSet<TransactionDetail>();
        }

        public int TransactionId { get; set; }
        public int? CustomerId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? Date { get; set; }
        public int? TotalAmount { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual Employee? Employee { get; set; }
        public virtual Profit? Profit { get; set; }
        public virtual ICollection<TransactionDetail> TransactionDetails { get; set; }

    }
}
