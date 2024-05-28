using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrderShopCart.Domain;
using OrderShopCart.Domain.Aggregates;

namespace OrderShopCart.Infrastructure.Presistance;

public class GroupConfiguration : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.ToTable(DbContextSchema.Group.TableName);

        builder.HasKey(x => x.Id);

        builder.Property(p => p.Id)
           .ValueGeneratedNever()
           .HasConversion(id =>
                           id.Value,
                           value => EntityId.Create(value));

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.Title)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.CreatedOn)
            .IsRequired()
            .HasDefaultValue(DateTime.Now);

        builder.HasMany(x => x.Products);

        builder.Navigation(x => x.Products)
            .Metadata
            .SetField(DbContextSchema.Group.ProductIdBackendField);
    }
}
