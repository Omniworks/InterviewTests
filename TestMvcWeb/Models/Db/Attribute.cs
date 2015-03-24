using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TestMvcWeb.Models.DB
{
    public partial class Attribute
    {
        public Attribute()
        {
            this.Inventories = new List<Inventory>();
        }

        public int Id { get; set; }

        [Required]
        [DisplayName("Attribute Name")]
        [StringLength(50)]
        public string Name { get; set; }
        
        [Required]
        [DisplayName("Maximum allowed choices")]
        public int Max_Allowed { get; set; }

        [Required]
        [DisplayName("Required?")]
        public bool Required { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; }
    }
}
