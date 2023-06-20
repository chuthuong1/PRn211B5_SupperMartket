using System;
using System.Collections.Generic;

namespace Product_Management.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Position { get; set; }
        public int? Salary { get; set; }
    }
}
