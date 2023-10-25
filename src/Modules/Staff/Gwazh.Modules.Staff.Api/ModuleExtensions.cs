using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Gwazh.Modules.Staff.Api;

public static class ModuleExtensions
{
    public static IServiceCollection AddStaffModule(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }

    public static void UseStaffModule(this WebApplication app)
    {
        app.MapGroup("api/staff")
            .MapGet("/", () => "Welcome to the staff module")
            .WithTags("Staff module");
    }
}