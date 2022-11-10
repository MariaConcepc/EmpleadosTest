using AutoMapper;
using Domain.Contract.Services;
using Domain.Services;
using Empleados.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Empleados.Controllers
{
   
    [Route("api/empleados")]
    [ApiController]
    public class EmpleadosController: ControllerBase
    {
        private readonly IEmpleadoService empleadoService;
        private readonly IMapper mapper;

        public EmpleadosController(IEmpleadoService empleadoService, IMapper mapper)
        {
            this.empleadoService = empleadoService;
            this.mapper = mapper;
        }


        [HttpGet]
       public async Task<ActionResult<EmpleadoDTO>> Get()
       {
            var empleados = await empleadoService.GetAllAsync();

            if (empleados == null || empleados.Count() == 0)
            {
                return NotFound();
            }

            return mapper.Map<EmpleadoDTO>(empleados);
       }
    }
}
