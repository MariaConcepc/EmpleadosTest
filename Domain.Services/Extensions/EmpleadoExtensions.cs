using Infraestructure.Persistence.Models;


namespace Domain.Services.Extensions
{
    public static class EmpleadoExtensions
    {
        public static Domain.Models.Empleado? ToDto(this Infraestructure.Persistence.Models.Empleado domain)
        {
            return domain == null
                ? null
                : new Domain.Models.Empleado()
                {
                    Id = domain.Id,
                    Name = domain.Name,
                    JobPossition = domain.JobPossition,
                    CreatedBy = domain.CreatedBy,
                    CreatedOn = domain.CreatedOn,
                    ModifiedBy = domain.ModifiedBy,
                    ModifiedOn = domain.ModifiedOn                    
                };
        }

        public static List<Domain.Models.Empleado> ToDtoList(this IEnumerable<Infraestructure.Persistence.Models.Empleado> domainList)
        {
            return domainList == null
                ? null
                : domainList.Select(s => s.ToDto()).ToList();
        }

        public static Infraestructure.Persistence.Models.Empleado  ToDto(this Domain.Models.Empleado domain)
        {
            return domain == null
                ? null
                : new Infraestructure.Persistence.Models.Empleado()
                {
                    Id = domain.Id,
                    Name = domain.Name,
                    JobPossition = domain.JobPossition,
                    CreatedBy = domain.CreatedBy,
                    CreatedOn = domain.CreatedOn,
                    ModifiedBy = domain.ModifiedBy,
                    ModifiedOn = domain.ModifiedOn
                };
        }
    }
}
