﻿using System;
using System.Collections.Generic;

namespace Product_Management.Models
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
    }
}
