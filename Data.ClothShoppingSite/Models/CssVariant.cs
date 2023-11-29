using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.ClothShoppingSite.Models
{
    public class CssVariant
    {
        [Key]
        public int Code { get; set; }

        public CssProduct Product { get; set; }

        public CssKind Kind { get; set; }
        public int Gsize { get; set; }
        public int Gcolor { get; set; }
        public int Quantity { get; set; }
       public CssGallery gallery { get; set; }
    }
}
