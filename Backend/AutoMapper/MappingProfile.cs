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

            CreateMap<AlumnoInsertDto, AlumnoDto>()
                .ReverseMap();

            CreateMap<AlumnoUpdateDto, AlumnoDto>()
                .ReverseMap();

            CreateMap<Alumno, AlumnoUpdateDto>().ForMember(
                dto => dto.id,
                alumno => alumno.MapFrom(alu => alu.Id));
                
        }
    }
}
