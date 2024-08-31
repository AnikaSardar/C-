using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSpring2024Demo.DBClasses
{
    public partial class Admin
    {
        public Admin()
        {
            Customers = new HashSet<Customer>();
        }

        [Key]
        [Column("AdminID")]
        public int AdminId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string FirstName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string LastName { get; set; } = null!;
        [StringLength(15)]
        [Unicode(false)]
        public string Phone { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string Email { get; set; } = null!;

        [InverseProperty("Admin")]
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
