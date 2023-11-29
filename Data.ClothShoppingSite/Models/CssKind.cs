using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.ClothShoppingSite.Models
{
    public class CssKind
    {
        [Key]
        public int Code { get; set; }
        public string Kind { get; set; }
    }
}
