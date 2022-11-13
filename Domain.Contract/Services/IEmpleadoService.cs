
using Domain.Models;

namespace Domain.Contract.Services;

    public interface IEmpleadoService
    {
        Task<ICollection<Empleado>> GetAllAsync();

        Task<Empleado> GetById(Guid id);
    }
