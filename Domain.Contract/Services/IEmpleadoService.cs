
using Domain.Models;

namespace Domain.Contract.Services;

    public interface IEmpleadoService
    {
        Task<IEnumerable<Empleado>> GetAllAsync();
    }
