using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainLayer.EntityMapper
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("pk_product");

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id");

            builder.Property(x => x.Name)
                .HasColumnName("Product_Name")
                .HasColumnType("NVARCHAR(200)")
                .IsRequired();

            builder.Property(x => x.Price)
                .HasColumnName("Price")
                .IsRequired();

            builder.Property(x => x.CreatedDate)
                .HasColumnName("created_date")
                .HasColumnType("datetime");

            builder.Property(x => x.ModifiedDate)
                .HasColumnName("modified_date")
                .HasColumnType("datetime");

            builder.Property(x => x.IsActive)
                .HasColumnName("is_active")
                .HasColumnType("bit");
        }
    }
}
