
using Domain.Models;

namespace Domain.Contract.Services;

    public interface IEmpleadoService
    {
        Task<bool> Add(Empleado empleado);
        Task<ICollection<Empleado>> GetAllAsync();
        Task<Empleado> GetById(Guid id);
    }
