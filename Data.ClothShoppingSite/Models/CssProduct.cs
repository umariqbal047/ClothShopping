using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.ClothShoppingSite.Models
{
    public class CssProduct
    {
        [Key]
        public int Code { get; set; }

        public string Description { get; set; }

        public decimal Cost { get; set; }
        public decimal Price { get; set; }

        public decimal Comparison { get; set; }
        public decimal Margin { get; set; }
        public decimal Profit { get; set; }
        public int Tax { get; set; }

        public string SKU { get; set; }
        public string UPC { get; set; }

        public decimal Quantity { get; set; }
        public decimal Max { get; set; }
        public decimal Min { get; set; }
        
        public CssWeight Weight { get; set; }
        public CssGeneral general { get; set; }
       

    }
}
