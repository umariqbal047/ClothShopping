using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.ClothShoppingSite.Models
{
    public class CssGallery
    {
        [Key]
        public int Code { get; set; }
       
        public CssKind Kind { get; set; }
        public string Picture { get; set; }
    }
}
