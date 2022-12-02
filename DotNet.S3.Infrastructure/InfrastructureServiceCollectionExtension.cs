using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DotNet.S3.Infrastructure;

public static class InfrastructureServiceCollectionExtension
{
    [SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "Ez itt nem lesz null")]
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }
}
