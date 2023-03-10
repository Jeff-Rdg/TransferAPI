using Microsoft.EntityFrameworkCore;
using TransferAPI.Data;
using TransferAPI.Repository.Interfaces;

namespace TransferAPI.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly TransferContext _context;

        public BaseRepository(TransferContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }


        public IEnumerable<T> GetAll()
        {
            var entities = _context.Set<T>().ToList();
            return entities;
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public T Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
            return entity;

        }
        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);

        }
    }
}
