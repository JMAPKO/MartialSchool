using FluentValidation;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Pakuayb.Dtos;
using Pakuayb.Services;
using Pakuayb.Validator;

namespace Pakuayb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {
        private IBaseServices<AlumnoDto,AlumnoInsertDto, AlumnoUpdateDto> _services;
        private IValidator<AlumnoInsertDto> _insertValidator;
        private IValidator<AlumnoUpdateDto> _updateValiador;

        public AlumnosController(
            [FromKeyedServices("AlumnosService")]
            IBaseServices<AlumnoDto,AlumnoInsertDto, AlumnoUpdateDto> services,
            IValidator<AlumnoInsertDto> insertValidator,
            IValidator<AlumnoUpdateDto> updateValiador)
        {
            _services = services;
            _insertValidator = insertValidator;
            _updateValiador = updateValiador;
        }

        [HttpGet] //Traer todos
        public async Task<IEnumerable<AlumnoDto>> Get() =>
            await _services.TraerTodos();

        
        [HttpGet("{id}")] //Traer uno
       public async Task<ActionResult<AlumnoDto>> GetById(int id)
        {
            var alumno = await _services.GetById(id);

            return alumno == null ? NotFound("No se encontro el alumno") : Ok(alumno);
        }

        [HttpPost]
        public async Task<ActionResult<AlumnoDto>> Add(AlumnoInsertDto alumno)
        {
            var ResultValidator = await _insertValidator.ValidateAsync(alumno);
            if (!ResultValidator.IsValid)
            {
                Console.WriteLine("error de validacion");
                return BadRequest(ResultValidator.Errors);
            }

            if (!await _services.Validacion(alumno)) //si esto es falso
            {
                return BadRequest(_services.Errores);
            }

            var alu = await _services.Create(alumno);

            return CreatedAtAction(nameof(GetById), new { id = alu.Id }, alu);

        }

        [HttpPut("{id}")]
        public async Task<ActionResult<AlumnoDto>> Update(int id, AlumnoUpdateDto alumno)
        {
            var validator = await _updateValiador.ValidateAsync(alumno);
            if (!validator.IsValid)
            {
                Console.WriteLine("Error en el update");
                return BadRequest(validator.Errors);
            }

            if ( !await _services.Validacion(alumno))
            {
                Console.WriteLine("Error en el update");
               return NotFound(_services.Errores);
            }

             var alu = await _services.Update(id,alumno);
             return alu == null ? NotFound() : Ok(alu);

        }

    }
}
