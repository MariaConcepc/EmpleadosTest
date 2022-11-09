
using Infraestructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Persistence;

public class ApplicationDbContext : DbContext
{
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    DbSet<Empleado> Empleado { get; set; }  
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }

  
}
