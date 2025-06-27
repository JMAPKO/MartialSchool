using Microsoft.EntityFrameworkCore;

namespace Pakuayb.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        { }


        public DbSet<Alumno> Alumnos { get; set; }

        
    }
}
