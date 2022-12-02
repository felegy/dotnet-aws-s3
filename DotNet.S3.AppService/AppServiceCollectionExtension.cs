using Microsoft.Extensions.DependencyInjection;

namespace DotNet.S3.AppService;

public static class AppServiceCollectionExtension
{
    public static IServiceCollection AddAppServices(this IServiceCollection services)
    {
        return services;
    }
}
