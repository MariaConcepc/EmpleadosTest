using Infraestructure.Persistence.Constants;
using Infraestructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    internal static class AuditableEntityConfiguration
    {
        public static void ConfigureAuditableProperties<T>(this EntityTypeBuilder<T> builder) where T : AuditableEntity
        {
            builder.Property(x => x.CreatedOn).HasDefaultValueSql(SqlFunctions.GetDate);

            builder.Property(x => x.CreatedBy).HasMaxLength(255);
            builder.Property(x => x.ModifiedBy).HasMaxLength(255);
        }
    }

}
