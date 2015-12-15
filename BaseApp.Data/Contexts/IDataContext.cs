using System;
using System.Linq;

namespace BaseApp.Data.Contexts
{
    public interface IDataContext : IDisposable
    {
        void CommitChanges();

        IQueryable<TEntity> GetQueryable<TEntity>() where TEntity : class;

        void Upsert<TEntity>(TEntity entity, bool commitImmediately = true) where TEntity : class;

        void Remove<TEntity>(TEntity entity, bool commitImmediately = true) where TEntity : class;
    }
}
