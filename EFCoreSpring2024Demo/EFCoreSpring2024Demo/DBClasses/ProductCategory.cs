using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSpring2024Demo.DBClasses
{
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        [Column("ProductCategoryID")]
        public int ProductCategoryId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string ProductCategoryName { get; set; } = null!;

        [InverseProperty("ProductCategory")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
