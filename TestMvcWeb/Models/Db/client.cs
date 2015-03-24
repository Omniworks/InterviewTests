using System;
using System.Collections.Generic;

namespace TestMvcWeb.Models.DB
{
    public partial class Client
    {
        public Client()
        {
            this.Inventories = new List<Inventory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; }
    }
}
