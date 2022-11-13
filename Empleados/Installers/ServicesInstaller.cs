using System.Reflection;
using Domain.Contract.Services;
using Domain.Services;
using Empleados.Filters;

namespace Empleados.Installers
{
    public class ServicesInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<IEmpleadoService, EmpleadoService>();

            services.AddTransient<MyActionFilter>();

        }
    }
}
