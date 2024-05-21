using Microsoft.Extensions.DependencyInjection;


namespace OrderShopCart.Application;

public static class DependencyInjection
{
    public static IServiceCollection ConfigureApplicationLayer(this IServiceCollection services)
    {

        var application = typeof(IAssemblyMarker);
        services.AddMediatR(config => config.RegisterServicesFromAssembly(application.Assembly));

        return services;
    }
}
