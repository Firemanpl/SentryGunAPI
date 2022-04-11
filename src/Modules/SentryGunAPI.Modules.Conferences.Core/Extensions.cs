using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
[assembly:InternalsVisibleTo("SentryGunAPI.Modules.Conferences.Api")]
namespace SentryGunAPI.Modules.Conferences.Core;

internal static class Extensions
{
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        return services;
    }
}