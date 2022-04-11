using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using SentryGunAPI.Modules.Conferences.Core;

[assembly:InternalsVisibleTo("SentryGunAPI.Bootstrapper")]
namespace SentryGunAPI.Modules.Conferences.Api;

internal static class Extensions
{
    public static IServiceCollection AddConferences(this IServiceCollection services)
    {
        services.AddCore();
        return services;
    }
}