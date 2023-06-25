using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RealtyWebApplication.Core.Models
{
    public class Owner
    {
        [Key]
        public int OwnerId { get; set; }
        [Required]
        public string OwnerName { get; set; }
    }
}
