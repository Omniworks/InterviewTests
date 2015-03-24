using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TestMvcWeb.Models.DB;

namespace TestMvcWeb.Models.Mapping
{
    public class pricelistMap : EntityTypeConfiguration<Pricelist>
    {
        public pricelistMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Size)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("pricelist");
            this.Property(t => t.Id).HasColumnName("id");
            this.Property(t => t.Inventory_Id).HasColumnName("inventory_id");
            this.Property(t => t.Size).HasColumnName("size");
            this.Property(t => t.Price).HasColumnName("price");

            // Relationships
            this.HasRequired(t => t.Inventory)
                .WithMany(t => t.Pricelists)
                .HasForeignKey(d => d.Inventory_Id);

        }
    }
}
