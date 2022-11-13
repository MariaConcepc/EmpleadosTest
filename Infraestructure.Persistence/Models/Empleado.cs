

namespace Infraestructure.Persistence.Models
{
    public class Empleado : AuditableEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string JobPossition { get; set; }

        public string? UrlPicture { get; set; }
    }
}
