using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSpring2024Demo.DBClasses
{
    public partial class CustomerCategory
    {
        public CustomerCategory()
        {
            Customers = new HashSet<Customer>();
            InvoiceLineItems = new HashSet<InvoiceLineItem>();
        }

        [Key]
        [Column("CustomerCategoryID")]
        public int CustomerCategoryId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string CustomerCategoryName { get; set; } = null!;
        [Column(TypeName = "decimal(18, 3)")]
        public decimal DiscountRate { get; set; }

        [InverseProperty("CustomerCategory")]
        public virtual ICollection<Customer> Customers { get; set; }
        [InverseProperty("CustomerCategory")]
        public virtual ICollection<InvoiceLineItem> InvoiceLineItems { get; set; }
    }
}
