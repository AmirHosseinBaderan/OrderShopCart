using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OrderShopCart.Domain.Common;
using OrderShopCart.Infrastructure.Presistance;
using OrderShopCart.Infrastructure.Presistance.Common;

namespace OrderShopCart.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection ConfigureInfrastructureLayer(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<OrderDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString(DbContextSchema.DefaultConnectionStringName)));

        services.AddScoped(typeof(IBaseCud<>), typeof(BaseCud<>));
        services.AddScoped(typeof(IBaseQuery<>), typeof(BaseQuery<>));

        return services;
    }
}
