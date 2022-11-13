namespace Empleados.DTO
{
    public class EmpleadoCreationDTO
    {
        public string Name { get; set; }
        public string JobPossition { get; set; }
        public IFormFile Picture { get; set; }
    }
}
