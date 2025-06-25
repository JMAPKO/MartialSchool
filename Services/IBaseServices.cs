namespace Pakuayb.Services
{
    public interface IBaseServices<T>
    {
        public Task<IEnumerable<T>> TraerTodos();//Traer todos

        public Task<T> GetById(int id);//Traer por Id

        public Task Create(T entity);//Crear

        public Task<T> Update(int id, T entity);//Actualizar

        public Task<T> Delete(int id);//Eliminar
    }
}
