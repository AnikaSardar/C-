using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSpring2024Demo.DBClasses
{
    public partial class Customer
    {
        public Customer()
        {
            Invoices = new HashSet<Invoice>();
        }

        [Key]
        [Column("CustomerID")]
        public int CustomerId { get; set; }
        [Column("CustomerCategoryID")]
        public int CustomerCategoryId { get; set; }
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

        [ForeignKey("AdminId")]
        [InverseProperty("Customers")]
        public virtual Admin Admin { get; set; } = null!;
        [ForeignKey("CustomerCategoryId")]
        [InverseProperty("Customers")]
        public virtual CustomerCategory CustomerCategory { get; set; } = null!;
        [InverseProperty("Customer")]
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
