using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace claimsHandling.Models
{
    public partial class User
    {
        [Key]
        public int UserId { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string UserName { get; set; } = null!;
        [StringLength(20)]
        [Unicode(false)]
        public string Password { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string DisplayName { get; set; } = null!;
        [Required]
        public bool? Active { get; set; }
    }
}
