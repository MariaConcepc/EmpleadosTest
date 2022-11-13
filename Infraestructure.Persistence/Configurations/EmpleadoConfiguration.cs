

using Infraestructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    internal class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).HasMaxLength(250).IsRequired(true);
            builder.Property(x => x.JobPossition).HasMaxLength(250).IsRequired(true);
            builder.Property(x => x.UrlPicture).HasMaxLength(500).IsRequired(false);
        }
    }  
}
