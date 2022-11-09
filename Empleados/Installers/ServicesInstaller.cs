using System.Reflection;
using Domain.Contract.Services;
using Domain.Services;

namespace Empleados.Installers
{
    public class ServicesInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

           // services.AddScoped<IEmpleadoService, EmpleadoService>();
            
        }
    }
}
