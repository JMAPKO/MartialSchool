using Microsoft.EntityFrameworkCore;
using Pakuayb.Models;

namespace Pakuayb.Repository
{
    public class AlumnosRepository : IRepository<Alumno>
    {

        private SchoolContext _context;

        public AlumnosRepository(SchoolContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Alumno>> GetAll()
        {
            var alumnos = await _context.Alumnos.ToListAsync();
            return alumnos;
        }

        public Task<Alumno> GetById(int id)
        {
            throw new NotImplementedException();
        }
        public Task Create(Alumno entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Alumno entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }


        public void SaveChanges()
        {
            throw new NotImplementedException();
        }


    }
}
