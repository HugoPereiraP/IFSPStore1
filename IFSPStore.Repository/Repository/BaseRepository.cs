using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFSPStore.Domain.Base;
using IFSPStore.Repository.Context;
using IFSPStore.Repository.Repository;
using Microsoft.EntityFrameworkCore;

namespace IFSPStore.Repository.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity<int>
    {
        /*
         * protected IFSPStoreContext _mysqlContext;
        
        public BaseRepository(IFSPStoreContext mySqlContext)
        {
            _mysqlContext = mySqlContext;
        }
        public void AttachObject()
        {
           _mysqlContext.Attach(obj);
        }
        public void CleanChangeTracker()
        {
            _mysqlContext.ChangeTracker.Clear();    
        }
        public void delete(object id)
        {
            _mysqlContext.Set<TEntity>().Remove(Select(id));   
            _mysqlContext.SaveChanges();
        }
        */
        protected IFSPStoreContext _mysqlContext;
        public BaseRepository(IFSPStoreContext mySqlContext)
        {
            _mysqlContext = mySqlContext;
        }

        public void AttachObject(object obj)
        {
            _mysqlContext.Attach(obj);
            _mysqlContext.SaveChanges();
        }

        public void CleanChangeTracker()
        {
            _mysqlContext.ChangeTracker.Clear();
            _mysqlContext.SaveChanges();
        }

        public void delete(object id)
        {
           _mysqlContext.Set<TEntity>().Remove(SelectById(id)!);
            _mysqlContext.SaveChanges();
        }

        public void Insert(TEntity obj)
        {
            _mysqlContext.Set<TEntity>().Add(obj);
            _mysqlContext.SaveChanges();
        }

        public IList<TEntity> Select(IList<string>? includes = null)
        {
            var dbContext = _mysqlContext.Set<TEntity>().AsQueryable();
            if (includes != null)
            {
                  foreach (var include in includes)
                {
                    dbContext = dbContext.Include(include);
                }
            }
            return dbContext.ToList();
        }

        public TEntity? SelectById(object id, IList<string>? includes = null)
        {
           var dbContext = _mysqlContext.Set<TEntity>().AsQueryable();
            if (includes != null)
            {
                  foreach (var include in includes)
                {
                    dbContext = dbContext.Include(include);
                }
            }
            return dbContext.FirstOrDefault(e => e.Id.Equals(id));
        }

        public void update(TEntity obj)
        {
            _mysqlContext.Set<TEntity>().Update(obj);
            _mysqlContext.SaveChanges();
        }
    }
}
