using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Gwazh.Modules.Academic.Api;

public static class ModuleExtensions
{
    public static IServiceCollection AddAcademicModule(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }

    public static void UseAcademicModule(this WebApplication app)
    {
        app.MapGroup("api/academic")
            .MapGet("/", () => "Welcome to the academic module")
            .WithTags("Academic module");
    }
}