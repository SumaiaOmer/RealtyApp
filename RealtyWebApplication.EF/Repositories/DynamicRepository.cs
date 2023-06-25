using Microsoft.EntityFrameworkCore;
using RealtyWebApplication.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyWebApplication.EF.Repositories
{
    public class DynamicRepository<T> : IDynamicRepository<T> where T : class
    {
        private ApplicationDbContext _db;
        public DynamicRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public T AddData(T entity)
        {
            _db.Set<T>().Add(entity);
            _db.SaveChanges();
            return entity;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _db.Set<T>().ToListAsync();
        }

        

        public async Task<T> GetById(int id)
        {
            return await _db.Set<T>().FindAsync(id);
        }

        public T ModifyData(T entity)
        {
            
            _db.Set<T>().Update(entity);
            _db.SaveChanges();
            return entity;
        }

        public T RemoveData(T entity)
        {

            _db.Set<T>().Remove(entity);
            _db.SaveChanges();
            return entity;
        }

    }
}
