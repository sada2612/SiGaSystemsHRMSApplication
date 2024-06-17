using Siga_Hrms.ApiService.Interfaces;
using Siga_Hrms.ApiService.Service;
using Siga_Hrms.Data.Interfaces;
using Siga_Hrms.Data.Repository;

namespace Siga_Systems.HRMS.ApiService
{
    public static class ServiceCollectionExtenstion
    {
        public static void AddService(IServiceCollection Services)
        {
            Services.AddTransient<IUserRepository, UserRepository>();
            Services.AddTransient<IUserService, UserService>();
        }
    }
}
