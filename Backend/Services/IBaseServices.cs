namespace Pakuayb.Services
{
    public interface IBaseServices<T,TI, TU>
    {
        public List<String> Errores { get; }
        public Task<IEnumerable<T>> TraerTodos();//Traer todos

        public Task<T> GetById(int id);//Traer por Id

        public Task<T> Create(TI entity);//Crear

        public Task<T> Update(int id, TU entity);//Actualizar

        public Task<T> Delete(int id);//Eliminar

        //Validaciones - Errores
        Task<Boolean> Validacion(TI entity);
        Task<Boolean> Validacion(TU entity);
    }
}
