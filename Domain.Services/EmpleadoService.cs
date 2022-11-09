using Domain.Contract.Infrastructure;
using Domain.Contract.Services;
using Domain.Models;

namespace Domain.Services
{
    public class EmpleadoService : IEmpleadoService
    {
        private readonly IUnitOfWork unitOfWork;

        public EmpleadoService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

      
        public async Task<IEnumerable<Empleado>> GetAllAsync()
        {
            var empleados = await unitOfWork.Empleados.GetAllEmployeeAsync();
            return (IEnumerable<Empleado>)empleados;
         
        }

    }
}