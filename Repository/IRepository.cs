namespace Pakuayb.Repository
{
    public interface IRepository<TEntity>
    {
        public Task<IEnumerable<TEntity>> GetAll(); // traer todo DB
        public Task<TEntity> GetById(int id); // traer por Id
        public Task Create(TEntity entity); // crear
        public void Update(TEntity entity); // actualizar
        public void Delete(int id); // eliminar
        public void SaveChanges(); // guardar cambios
    }
}
