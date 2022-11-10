using AutoMapper;
using Domain.Services;
using Empleados.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;

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

        [HttpGet("Id:int")]
        public async Task<ActionResult<EmpleadoDTO>> Get(int Id)
        {
            return NoContent();
        }
    }
}
