//using API.Consultas.Domain.Services;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Consultas.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultasController : Controller
    {
        private readonly IMapper mapper;
        //private readonly IConsultasService consultasService;

        public ConsultasController(
           IMapper mapper//,
           //IConsultasService consultasService
            )
        {
            this.mapper = mapper
                ?? throw new ArgumentNullException(nameof(mapper));

           // this.consultasService = consultasService
               // ?? throw new ArgumentNullException(nameof(consultasService));
        }

        [HttpGet("{clienteId}"), AllowAnonymous]
        public async Task<IActionResult> ObterConsultasPorClienteIdAsync(Guid clienteId)
        {
            try
            {
                var consultaRetorno = 2;

                return Ok(consultaRetorno);
            }
            catch
            {
                return NotFound();
            }  
        }
    }
}
