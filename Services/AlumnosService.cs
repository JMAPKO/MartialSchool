using System.Threading.Tasks;
using AutoMapper;
using Pakuayb.Dtos;
using Pakuayb.Models;
using Pakuayb.Repository;

namespace Pakuayb.Services
{
    public class AlumnosService : IBaseServices<AlumnoDto,AlumnoInsertDto, AlumnoUpdateDto>
    {
        private IRepository<Alumno> _repository;
        private IMapper _mapper;

        //Errores - lista
        public List<string> Errores { get; }

        public AlumnosService(IRepository<Alumno> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
            Errores = new List<string>();
        }


        public async Task<IEnumerable<AlumnoDto>> TraerTodos() //TRAER TODOS
        {
            var alumnos = await _repository.GetAll();
            
            return alumnos.Select(a => _mapper.Map<AlumnoDto>(a));
        }

        public async Task<AlumnoDto> GetById(int id) //TRAER UNO
        {
            var alumno = await _repository.GetById(id);
            var alumnoDto = _mapper.Map<AlumnoDto>(alumno);

            return alumnoDto;

        }

        public async Task<AlumnoDto> Create(AlumnoInsertDto entity)
        {
            var alumno = _mapper.Map<Alumno>(entity);
            await _repository.Create(alumno);
            _repository.SaveChanges(); // Guardar en DB

            var alumnoDto = _mapper.Map<AlumnoDto>(alumno);
            return alumnoDto;

        }

        public async Task<AlumnoDto> Update(int id, AlumnoUpdateDto entity)
        {
            var alumno = await _repository.GetById(id);
            
            if (alumno != null)
            {
                alumno = _mapper.Map<AlumnoUpdateDto, Alumno>(entity, alumno);
                
                _repository.Update(alumno);

                await _repository.SaveChanges();

                var AlumnoDto = _mapper.Map<AlumnoDto>(alumno);
                
                return AlumnoDto;
            }

            return null;
        }

        public Task<AlumnoDto> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Validacion(AlumnoInsertDto entity)
        {   
            Errores.Clear();
            
            if( await _repository.Exists(a =>  entity.Nombre == a.Nombre))
            {
                
                Errores.Add("Este alumno ya existe en la DB");
                return false;
            }

            return true;
        }
    }
}
