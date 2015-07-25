using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class UpdateStockVM
    {
        public int ProductId { get; set; }
        [Required]
        public decimal Stock { get; set; }
    }
}