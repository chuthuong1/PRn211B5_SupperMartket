using System;
using System.Collections.Generic;

namespace Product_Management.Models
{
    public partial class Userr
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int Role { get; set; }
        public byte[] CreatedAt { get; set; } = null!;
    }
}
