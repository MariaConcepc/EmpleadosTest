using Domain.Contract.Repository;

namespace Domain.Contract.Infrastructure
{
    public interface IUnitOfWork: IDisposable
    {
        IEMPLEADOSRepository Empleados { get;  }

        Task<bool> SaveChangesAsync();
    }
}