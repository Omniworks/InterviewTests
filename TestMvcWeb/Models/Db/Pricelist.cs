using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TestMvcWeb.Models.DB
{
    public partial class Pricelist
    {
        public Pricelist()
        {
            
        }

        public int Id { get; set; }
        public int Inventory_Id { get; set; }
        [Required]
        [DisplayName("Size")]
        [StringLength(50)]
        public string Size { get; set; }

        [Required]
        [DisplayName("Unit Price")]
        [DisplayFormat(DataFormatString = "{0:f2}")]
        public decimal Price { get; set; }

        public virtual Inventory Inventory { get; set; }
    }
}
