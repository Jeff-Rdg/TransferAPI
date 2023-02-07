namespace TransferAPI.Repository.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        public void Create(T entity);
        public T Update(T entity);
        public T GetById(int id);
        public IEnumerable<T> GetAll();
        public T Delete(T entity);

    }
}
