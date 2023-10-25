using Gwazh.Modules.Academic.Api;
using Gwazh.Modules.Admin.Api;
using Gwazh.Modules.Admissions.Api;
using Gwazh.Modules.Finance.Api;
using Gwazh.Modules.Staff.Api;

namespace Gwazh.Bootstrapper.Extensions;

internal static class WebApplicationExtensions
{
    public static void UseModules(this WebApplication app)
    {
        app.UseAcademicModule();
        app.UseAdminModule();
        app.UseAdmissionsModule();
        app.UseFinanceModule();
        app.UseStaffModule();
    }
}