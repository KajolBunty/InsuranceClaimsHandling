using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace claimsHandling.Models
{
    public partial class LossType
    {
        [Key]
        public int LossTypeId { get; set; }
        [StringLength(2)]
        [Unicode(false)]
        public string LossTypeCode { get; set; } = null!;
        [StringLength(25)]
        [Unicode(false)]
        public string LossTypeDescription { get; set; } = null!;
        [Required]
        public bool? Active { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public int LastUpdatedId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedId { get; set; }
    }
}
