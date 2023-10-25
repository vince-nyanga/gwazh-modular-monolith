using Gwazh.Modules.Academic.Api;
using Gwazh.Modules.Admin.Api;
using Gwazh.Modules.Admissions.Api;
using Gwazh.Modules.Finance.Api;
using Gwazh.Modules.Staff.Api;

namespace Gwazh.Bootstrapper.Extensions;

internal static class ServiceCollectionExtensions
{
    public static IServiceCollection AddModules(this IServiceCollection services, IConfiguration configuration)
    {
        return services.AddAcademicModule(configuration)
            .AddAdminModule(configuration)
            .AddAdmissionsModule(configuration)
            .AddFinanceModule(configuration)
            .AddStaffModule(configuration);
    }
}