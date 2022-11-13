namespace Empleados.Installers
{
    public class CorsInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
           services.AddCors(options =>
           {
               var frontUrl = configuration.GetValue<string>("frontEndUrl");
               options.AddDefaultPolicy(builder => {
                   builder.WithOrigins("http://localhost:4200")
                  .AllowAnyMethod()
                  .AllowAnyHeader();
               });
           });
        }
    }
}
