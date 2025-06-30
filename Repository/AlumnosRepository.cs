using System.Linq.Expressions;
using System.Threading.Tasks;
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

        public async Task<Alumno> GetById(int id)
        {
            var alumno = await _context.Alumnos.FindAsync(id);
            return alumno;
        }
        public async Task Create(Alumno entity)
        {
            var alumno = await _context.AddAsync(entity);
            
        }

        public void Update(Alumno entity)
        {
            _context.Attach(entity); //se posiciona
            _context.Entry(entity).State = EntityState.Modified; //modifica
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChanges() => _context.SaveChangesAsync(); //guardar cambios

        //control de existencia
        public async Task<bool> Exists(Expression<Func<Alumno, bool>> filter)
        {
            var encontrado = await _context.Alumnos.Where(filter).AnyAsync();
            return encontrado;
        }
    }
}
