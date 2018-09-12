using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BangazonAPI.Models
{
    public class Computers
    {
        [Key]
        public int CompuersId { get; set; }

        [Required]
        public DATE DatePurchased { get; set; }
        public DatePurchased DatePurchased { get; set; }

        [Required]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}