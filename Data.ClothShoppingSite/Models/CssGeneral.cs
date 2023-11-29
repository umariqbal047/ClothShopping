using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.ClothShoppingSite.Models
{
    public class CssGeneral
    {
        [Key]
        public int Code { get; set; }
        public CssKind kind { get; set; }

        public string Description { get; set; }
    }
}
