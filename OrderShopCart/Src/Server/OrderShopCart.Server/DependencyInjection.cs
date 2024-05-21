using FluentValidation;
using Mapster;
using MapsterMapper;
using Microsoft.Extensions.DependencyInjection.Extensions;
using OrderShopCart.Server.Abstraction;
using System.Reflection;

namespace OrderShopCart.Server;

public static class DependencyInjection
{
    private readonly static Assembly[] Assemblies = AppDomain.CurrentDomain.GetAssemblies();

    public static IServiceCollection ConfigureMapster(this IServiceCollection services)
    {
        var typeAdapterConfig = TypeAdapterConfig.GlobalSettings;

        services.AddSingleton(typeAdapterConfig);
        services.AddScoped<IMapper, ServiceMapper>();

        return services;
    }

    public static IServiceCollection ConfigureValidator(this IServiceCollection services)
    {

        services.AddValidatorsFromAssemblies(Assemblies);

        return services;
    }

    public static IServiceCollection ConfigureCors(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy(name: "AllowOrigin",
                builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyHeader()
                           .AllowAnyMethod();
                });
        });

        return services;
    }


    public static IServiceCollection AddEndpoints(this IServiceCollection services)
    {
        var assembly = typeof(IAssemblyMarker).Assembly;

        ServiceDescriptor[] serviceDescriptors = assembly
                .DefinedTypes
                .Where(t => t is { IsAbstract: false, IsSealed: false, IsInterface: false }
                                && t.IsAssignableTo(typeof(IEndpoint)))
                .Select(t => ServiceDescriptor.Transient(typeof(IEndpoint), t))
                .ToArray();

        services.TryAddEnumerable(serviceDescriptors);

        return services;
    }

    public static IApplicationBuilder MapEndpoints(this WebApplication app)
    {
        var endpoints = app.Services.GetRequiredService<IEnumerable<IEndpoint>>();
        foreach (var endpoint in endpoints)
            endpoint.MapEndpoint(app);

        return app;
    }

}
