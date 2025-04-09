using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations
{
    public class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(P => P.ProductBrand)
                    .WithMany()
                    .HasForeignKey(p => p.BrandId);

            builder.HasOne(P => P.ProductType)
                    .WithMany()
                    .HasForeignKey(p => p.TypeId);
        }
    }
}
