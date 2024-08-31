using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSpring2024Demo.DBClasses
{
    [Keyless]
    public partial class AdminCredential
    {
        [Column("AdminID")]
        public int AdminId { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Username { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string Passwords { get; set; } = null!;

        [ForeignKey("AdminId")]
        public virtual Admin Admin { get; set; } = null!;
    }
}
