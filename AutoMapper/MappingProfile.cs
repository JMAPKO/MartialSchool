using AutoMapper;
using Pakuayb.Dtos;
using Pakuayb.Models;

namespace Pakuayb.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Alumno, AlumnoDto>()
                .ReverseMap();
        }
    }
}
