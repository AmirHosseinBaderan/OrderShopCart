using Microsoft.EntityFrameworkCore;
using OrderShopCart.Domain.Aggregates;

namespace OrderShopCart.Infrastructure.Presistance;

public class OrderDbContext(DbContextOptions<OrderDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products => Set<Product>();

    public DbSet<Group> Groups => Set<Group>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var infrastructureAssebmly = typeof(IAssemblyMarker).Assembly;
        modelBuilder.ApplyConfigurationsFromAssembly(infrastructureAssebmly);
    }
}
