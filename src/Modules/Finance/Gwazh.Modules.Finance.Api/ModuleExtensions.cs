using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Gwazh.Modules.Finance.Api;

public static class ModuleExtensions
{
    public static IServiceCollection AddFinanceModule(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }

    public static void UseFinanceModule(this WebApplication app)
    {
        app.MapGroup("api/finance")
            .MapGet("/", () => "Welcome to the finance module")
            .WithTags("Finance module");
    }
}