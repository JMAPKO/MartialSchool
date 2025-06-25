using Microsoft.AspNetCore.Mvc;
using Pakuayb.Dtos;
using Pakuayb.Services;

namespace Pakuayb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {
        private IBaseServices<AlumnoDto> _services;

        public AlumnosController( 
            [FromKeyedServices("AlumnosService")] IBaseServices<AlumnoDto> services)
        {
            _services = services;
        }

        [HttpGet]
        public async Task<IEnumerable<AlumnoDto>> Get() => 
            await _services.TraerTodos();
        


    }
}
