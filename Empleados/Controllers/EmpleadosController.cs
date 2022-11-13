using AutoMapper;
using Domain.Contract.Services;
using Domain.Models;
using Domain.Services;
using Empleados.DTO;
using Empleados.Filters;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;

namespace Empleados.Controllers
{
   
    [Route("api/empleados")]
    [ApiController]
    public class EmpleadosController: ControllerBase
    {
        private readonly ILogger logger;
        private readonly IEmpleadoService empleadoService;
        private readonly IMapper mapper;

        public EmpleadosController(ILogger<EmpleadosController> logger, IEmpleadoService empleadoService, IMapper mapper)
        {
            this.logger = logger;
            this.empleadoService = empleadoService;
            this.mapper = mapper;
        }


        [HttpGet]
        //[ResponseCache(Duration = 30)]
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [ServiceFilter(typeof(MyActionFilter))]
        public async Task<ActionResult<EmpleadoDTO>> Get()
        {
            logger.LogInformation("Iniciando el get de Empleados");

            var empleados = await empleadoService.GetAllAsync();

            if (empleados == null || empleados.Count() == 0)
            {                
                logger.LogWarning("no hay datos");
                return NotFound();
            }

            return mapper.Map<EmpleadoDTO>(empleados);
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<ActionResult<EmpleadoDTO>> Get(Guid
            Id)
        {
            //var employee = await empleadoService.GetById(Id);
            var employee = new Empleado();
            return mapper.Map<EmpleadoDTO>(employee);
        }

        [HttpPost]
        public async Task<ActionResult> Add([FromForm] EmpleadoDTO employeeDTO)
        {
           // await empleadoService.Add(mapper.Map<Empleado>(employeeDTO));
            return NoContent();
        }
    }
}
