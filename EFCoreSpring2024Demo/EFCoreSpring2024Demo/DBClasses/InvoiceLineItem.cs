using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSpring2024Demo.DBClasses
{
    public partial class InvoiceLineItem
    {
        [Key]
        [Column("InvoiceID")]
        public int InvoiceId { get; set; }
        [Key]
        [StringLength(10)]
        [Unicode(false)]
        public string ProductCode { get; set; } = null!;
        [Column("CustomerCategoryID")]
        public int CustomerCategoryId { get; set; }
        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "money")]
        public decimal ItemTotal { get; set; }

        [ForeignKey("CustomerCategoryId")]
        [InverseProperty("InvoiceLineItems")]
        public virtual CustomerCategory CustomerCategory { get; set; } = null!;
        [ForeignKey("InvoiceId")]
        [InverseProperty("InvoiceLineItems")]
        public virtual Invoice Invoice { get; set; } = null!;
        [ForeignKey("ProductCode")]
        [InverseProperty("InvoiceLineItems")]
        public virtual Product ProductCodeNavigation { get; set; } = null!;
    }
}
