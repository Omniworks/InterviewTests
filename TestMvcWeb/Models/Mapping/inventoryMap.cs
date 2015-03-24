using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TestMvcWeb.Models.DB;

namespace TestMvcWeb.Models.Mapping
{
    public class inventoryMap : EntityTypeConfiguration<Inventory>
    {
        public inventoryMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Product)
                .HasMaxLength(50);

            this.Property(t => t.Comments)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("inventory");
            this.Property(t => t.Id).HasColumnName("id");
            this.Property(t => t.Client_Id).HasColumnName("client_id");
            this.Property(t => t.Product).HasColumnName("product");
            this.Property(t => t.Comments).HasColumnName("comments");

            this.HasRequired(t => t.Client)
                .WithMany(t => t.Inventories)
                .HasForeignKey(d => d.Client_Id);
            this.HasMany(p => p.Attributes)
                .WithMany(c => c.Inventories)
                .Map(m =>
                {
                    m.MapLeftKey("inventory_id");
                    m.MapRightKey("attribute_id");
                    m.ToTable("inventory_attribute");
                });
        }
    }
}
