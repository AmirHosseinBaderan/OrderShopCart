using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrderShopCart.Domain;
using OrderShopCart.Domain.Aggregates;

namespace OrderShopCart.Infrastructure.Presistance;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable(DbContextSchema.Product.TableName);

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
            .ValueGeneratedNever()
            .HasConversion(id =>
                            id.Value,
                            value => EntityId.Create(value));

        builder.Property(p => p.CreatedOn)
                .IsRequired();

        builder.Property(p => p.UpdatedOn)
                .IsRequired(false);

        builder.Property(p => p.Title)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(p => p.Description)
            .IsRequired()
            .HasMaxLength(1500);

        builder.OwnsMany(p => p.Tags,
                pt =>
                {
                    pt.ToTable(DbContextSchema.Product.TagTableName);
                    pt.Property(t => t.Value)
                        .IsRequired()
                        .HasMaxLength(30);
                })
            .UsePropertyAccessMode(PropertyAccessMode.Field);

        builder.Navigation(p => p.Tags)
            .Metadata
            .SetField(DbContextSchema.Product.TagIdBackednField);
    }
}
