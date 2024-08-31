using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSpring2024Demo.DBClasses
{
    public partial class Product
    {
        public Product()
        {
            InvoiceLineItems = new HashSet<InvoiceLineItem>();
        }

        [Key]
        [StringLength(10)]
        [Unicode(false)]
        public string ProductCode { get; set; } = null!;
        [Column("ProductCategoryID")]
        public int ProductCategoryId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string ProductName { get; set; } = null!;
        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }
        public int OnHandQuantity { get; set; }

        [ForeignKey("ProductCategoryId")]
        [InverseProperty("Products")]
        public virtual ProductCategory ProductCategory { get; set; } = null!;
        [InverseProperty("ProductCodeNavigation")]
        public virtual ICollection<InvoiceLineItem> InvoiceLineItems { get; set; }
    }
}
