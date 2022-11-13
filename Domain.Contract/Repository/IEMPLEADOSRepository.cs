using Infraestructure.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contract.Repository
{
    public interface IEMPLEADOSRepository
    {
        void Add(Empleado entity);
        Task<IEnumerable<Empleado>> GetAllEmployeeAsync();

        Task<Empleado> GetByIdAsync(object id);
    }
}
