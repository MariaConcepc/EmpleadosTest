using AutoMapper;
using Domain.Services;
using Empleados.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Empleados.Controllers
{
   
    [Route("api/empleados")]
    [ApiController]
    public class EmpleadosController: ControllerBase
    {
        private readonly EmpleadoService empleadoService;
        private readonly IMapper mapper;

        public EmpleadosController(EmpleadoService empleadoService, IMapper mapper)
        {
            this.empleadoService = empleadoService;
            this.mapper = mapper;
        }


        [HttpGet]
       public async Task<ActionResult<EmpleadoDTO>> Get()
       {
            var empleados = await empleadoService.GetAllAsync();

            if (empleados == null)
            {
                return NotFound();
            }

            return mapper.Map<EmpleadoDTO>(empleados);
       }
    }
}
