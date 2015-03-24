using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestMvcWeb.Models.DB
{
    public partial class Inventory
    {
        public Inventory()
        {
            this.Pricelists = new List<Pricelist>();
            this.Attributes = new List<Attribute>();
        }

        public int Id { get; set; }
        public int Client_Id { get; set; }

        [Required]
        [DisplayName("Product Description")]
        [StringLength(50)]
        public string Product { get; set; }

        [DisplayName("Comments")]
        [StringLength(50)]
        public string Comments { get; set; }
        public virtual Client Client { get; set; }

        public virtual ICollection<Pricelist> Pricelists { get; set; }
        public virtual ICollection<Attribute> Attributes { get; set; }
    }
}
