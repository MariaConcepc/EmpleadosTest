﻿using Domain.Contract.Repository;
using Infraestructure.Persistence;
using Infraestructure.Persistence.Models;
using Infrastucture.Repository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class EMPLEADOSRepository : GenericRepository<Empleado>, IEMPLEADOSRepository
    {
        public EMPLEADOSRepository(ApplicationDbContext context)
           : base(context,  null)
        {
        }


        public async Task<IEnumerable<Empleado>> GetAllEmployeeAsync()
        {
            return await _context.Empleado.ToListAsync();
        }

        public override async Task<Empleado> GetByIdAsync(object id)
        {
            return await _context.Empleado.FindAsync(id);
        }


    }
}
