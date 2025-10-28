using IFSPStore.Domain.Base;
using IFSPStore.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Repository.Repository;

public class BaseRepository<TEntity>(IFSPStoreDbContext context)
    : IBaseRepository<TEntity> where TEntity : BaseEntity<int>
{
    public void AttachObject(object obj)
    {
        context.Attach(obj);
    }

    public void CleanChageTracker()
    {
        context.ChangeTracker.Clear();
    }

    public void Delete(object id)
    {
        context.Set<TEntity>().Remove((TEntity)id);
        context.SaveChanges();
    }

    public void Insert(TEntity entity)
    {
        context.Set<TEntity>().Add(entity);
        context.SaveChanges();
    }

    public IList<TEntity> Select(IList<string>? includes = null)
    {
        var baseQuery = context.Set<TEntity>().AsQueryable();

        if(includes is not null)
        {
            foreach(var include in includes)
            {
                baseQuery = baseQuery.Include(include);
            }
        }
        return baseQuery.ToList();
    }

    public TEntity Select(object id, IList<string>? includes = null)
    {
        var baseQuery = context.Set<TEntity>().AsQueryable();

        if (includes is not null)
        {
            foreach (var include in includes)
            {
                baseQuery = baseQuery.Include(include);
            }
        }
        return baseQuery.ToList().Find(e => e.Id == (int)id);
    }

    public void Update(TEntity entity)
    {
        context.Set<TEntity>().Update(entity);
        context.SaveChanges();
    }
}
