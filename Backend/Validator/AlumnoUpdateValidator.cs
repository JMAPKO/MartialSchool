using FluentValidation;
using Pakuayb.Dtos;

namespace Pakuayb.Validator
{
    public class AlumnoUpdateValidator : AbstractValidator<AlumnoUpdateDto>
    {
        public AlumnoUpdateValidator()
        {
            RuleFor(alumno => alumno.Nombre)
                .NotEmpty().WithMessage("Debe agregarse un nombre al alumno");

        }
    }
}
