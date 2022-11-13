using Domain.Contract.Infrastructure;
using Domain.Contract.Services;
using Domain.Models;
using Domain.Services.Extensions;
using System.ComponentModel;

namespace Domain.Services
{
    public class EmpleadoService : IEmpleadoService
    {
        private readonly IUnitOfWork unitOfWork;

        public EmpleadoService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

      
        public async Task<ICollection<Empleado>> GetAllAsync()
        {
          //  var empleados = new List<Empleado>() { new Empleado() { Id = new Guid(), Name = "Conchita",JobPossition = "Dev"} };
                
            var empleados = await unitOfWork.Empleados.GetAllEmployeeAsync();
            return (ICollection<Empleado>)empleados.ToDtoList();
         
        }

        public async Task<Empleado> GetById(Guid id)
        {
            var empleado = await unitOfWork.Empleados.GetByIdAsync(id);
            return (Empleado)empleado.ToDto();
        }

        public async Task<bool> Add(Empleado empleado)
        {
            var employ = empleado.ToDto();
            unitOfWork.Empleados.Add(employ);
            return await unitOfWork.SaveChangesAsync();
        }


    }
}