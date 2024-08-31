using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSpring2024Demo.DBClasses
{
    [Keyless]
    public partial class CustomerCredential
    {
        [Column("CustomerID")]
        public int CustomerId { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Username { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string Passwords { get; set; } = null!;

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; } = null!;
    }
}
