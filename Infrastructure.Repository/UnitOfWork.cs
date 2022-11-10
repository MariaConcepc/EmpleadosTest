using Domain.Contract.Infrastructure;
using Domain.Contract.Repository;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext context;
        private bool disposedValue;

        public UnitOfWork(ApplicationDbContext context)
        {
            this.context = context;
            this.Empleados = new EMPLEADOSRepository(this.context);
        }

        public IEMPLEADOSRepository Empleados { get; private set; }

        public async Task<bool> SaveChangesAsync()
        {
            int affectedRows = await context.SaveChangesAsync();
            return affectedRows > 0;
        }


        public void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (context != null) context.Dispose();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

    }
}