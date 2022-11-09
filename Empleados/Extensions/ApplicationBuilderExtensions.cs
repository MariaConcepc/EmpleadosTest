using Empleados.Installers;
using System.Reflection;

namespace Empleados.Extensions
{
    internal static class ApplicationBuilderExtensions
    {
        public static void InstallServicesInAssembly(this WebApplicationBuilder builder)
        {
           var installers = Assembly.GetExecutingAssembly().GetTypes()
          .Where(t => typeof(IInstaller).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
          .Select(Activator.CreateInstance)
          .Cast<IInstaller>()
          .ToList();

            installers.ForEach(installer => installer.InstallServices(builder.Services, builder.Configuration));
        }

    }
}
