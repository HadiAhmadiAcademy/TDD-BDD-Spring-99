using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UOM.Domain.Model.Dimensions;

namespace UOM.Persistence.EF.Mappings
{
    public class DimensionMapping : IEntityTypeConfiguration<Dimension>
    {
        public void Configure(EntityTypeBuilder<Dimension> builder)
        {
            builder.ToTable("Dimensions");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();

            builder.Property(a => a.Name);
            builder.Property(a => a.Symbol);
        }
    }
}