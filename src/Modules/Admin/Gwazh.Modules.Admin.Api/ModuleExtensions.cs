using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Gwazh.Modules.Admin.Api;

public static class ModuleExtensions
{
    public static IServiceCollection AddAdminModule(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }

    public static void UseAdminModule(this WebApplication app)
    {
        app.MapGroup("api/admin")
            .MapGet("/", () => "Welcome to the admin module")
            .WithTags("Admin module");
    }
}