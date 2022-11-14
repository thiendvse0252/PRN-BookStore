using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Repository.Models;

namespace Repository {
    public class RepositoryBase {
    }

    public class RepositoryBase<T> where T : class {
        private readonly BookStoreContext _context;
        private readonly DbSet<T> _dbSet;
        public RepositoryBase() {
            _context = new BookStoreContext();
            _dbSet = _context.Set<T>();
        }

        public T Get(Guid id) {
            return _dbSet.FirstOrDefault();
        }

        public List<T> GetAll() {
            return _dbSet.ToList();
        }

        //unchecked
        public void Create(T entity) {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        //unchecked
        public void Update(T entity) {
            var tracker = _context.Attach(entity);
            tracker.State = EntityState.Modified;
            //_dbSet.Update(entity);
            _context.SaveChanges();
        }

        //unchecked
        public void Delete(T entity) {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }
    }
}
