using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.ClothShoppingSite.Models
{
    public class CssWeight
    {
        [Key]
        public int Code { get; set; }
        public string Description { get; set; }
        public decimal Weight { get; set; }
    }
}
    