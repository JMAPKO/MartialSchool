using System.Linq.Expressions;

namespace Pakuayb.Repository
{
    public interface IRepository<TEntity>
    {
         Task<IEnumerable<TEntity>> GetAll(); // traer todo DB
         Task<TEntity> GetById(int id); // traer por Id
         Task Create(TEntity entity); // crear
         void Update(TEntity entity); // actualizar
         void Delete(int id); // eliminar
         Task SaveChanges(); // guardar cambios


        //errores
        Task<bool> Exists(Expression<Func<TEntity, bool>> filter);
    }
}
