namespace TransferAPI.Repository.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        public void Create(T entity);
        public void Update(T entity);
        public T GetById(int id);
        public IEnumerable<T> GetAll();

    }
}
