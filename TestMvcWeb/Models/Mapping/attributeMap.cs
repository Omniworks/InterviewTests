using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TestMvcWeb.Models.DB;

namespace TestMvcWeb.Models.Mapping
{
    public class attributeMap : EntityTypeConfiguration<Attribute>
    {
        public attributeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("attribute");
            this.Property(t => t.Id).HasColumnName("id");
            this.Property(t => t.Name).HasColumnName("name");
            this.Property(t => t.Max_Allowed).HasColumnName("max_allowed");
            this.Property(t => t.Required).HasColumnName("required");

        }
    }
}
