using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RealtyWebApplication.Core.Models
{
   public class Realty
    {
        [Key]
        public int RealtyId { get; set; }
        [Required]
        public string RealtyName { get; set; }
        [Required]
        public int RealtyPrice { get; set; }
        [Required]
        public int OwnerId { get; set; }
        public Owner Owner  { get; set; }

    }
}
