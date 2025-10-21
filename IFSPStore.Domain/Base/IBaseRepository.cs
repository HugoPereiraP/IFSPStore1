using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Domain.Base
{
        public interface IBaseRepository<TEntity> where TEntity : IBaseEntity
    {
        public void CleanChangeTracker();

        public void AttachObject(object obj);

        public void Insert(TEntity obj);
        public void update(TEntity obj);

        public void delete(object id);

        IList<TEntity>Select(IList<string>? includes = null);
        TEntity? SelectById(object id, IList<string>? includes = null);
    }
}
