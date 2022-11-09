using AutoMapper;
using Domain.Models;
using Empleados.DTO;

namespace Empleados.Helpers
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Empleado, EmpleadoDTO>();
        }
        
    }
}
