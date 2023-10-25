using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Gwazh.Modules.Admissions.Api;

public static class ModuleExtensions
{
    public static IServiceCollection AddAdmissionsModule(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }

    public static void UseAdmissionsModule(this WebApplication app)
    {
        app.MapGroup("api/admissions")
            .MapGet("/", () => "Welcome to the admissions module")
            .WithTags("Admissions module");
    }
}