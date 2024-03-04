using Microsoft.Extensions.DependencyInjection;

namespace GerenciadorCandidatos.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(opts =>
        {
            opts.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
        });

        return services;
    }
}
