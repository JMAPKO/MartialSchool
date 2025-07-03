using FluentValidation;
using Pakuayb.Dtos;

namespace Pakuayb.Validator
{
    public class AlumnoInsertValidator : AbstractValidator<AlumnoInsertDto>
    {
        public AlumnoInsertValidator() 
        {
            RuleFor(alumno => alumno.Nombre)
                .NotEmpty().WithMessage("El nombre es obligatorio.");
        }
    }
}
