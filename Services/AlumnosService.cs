using AutoMapper;
using Pakuayb.Dtos;
using Pakuayb.Models;
using Pakuayb.Repository;

namespace Pakuayb.Services
{
    public class AlumnosService : IBaseServices<AlumnoDto>
    {
        private IRepository<Alumno> _repository;
        private IMapper _mapper;

        public AlumnosService(IRepository<Alumno> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public async Task<IEnumerable<AlumnoDto>> TraerTodos() //TRAER TODOS
        {
            var alumnos = await _repository.GetAll();
            
            return alumnos.Select(a => _mapper.Map<AlumnoDto>(a));
        }

        public Task<AlumnoDto> GetById(int id) //TRAER UNO
        {
            throw new NotImplementedException();
        }

        public Task Create(AlumnoDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<AlumnoDto> Update(int id, AlumnoDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<AlumnoDto> Delete(int id)
        {
            throw new NotImplementedException();
        }

        
        
    }
}
