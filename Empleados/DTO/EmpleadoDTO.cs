namespace Empleados.DTO
{
    public class EmpleadoDTO : AuditableEntityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobPossition { get; set; }
    }
}
