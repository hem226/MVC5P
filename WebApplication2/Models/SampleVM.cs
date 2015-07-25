using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class SampleVM
    {
        [Required]
        public string name { get; set; }
        [Required]
        public string title { get; set; }
        public string level { get; set; }
    }
}
