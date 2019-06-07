using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using WebApiCoreWithJWT.Infra.DataAccess.Repositories;
using WebApiCoreWithJWT.Infra.DataAccess.Sql.Contexts;

namespace WebApiCoreWithJWT.Infra.DataAccess.Sql.Repositories
{
    public abstract class RepositoryBase<T> : IDisposable, IRepositoryBase<T> where T : class
    {
        protected DbContextMain Context { get; }

        #region Ctor

        public RepositoryBase(DbContextMain context)
        {
            Context = context ?? throw new ArgumentNullException("Context cannot be null.");
        }

        #endregion Ctor

        public void Add(T item)
        {
            Context.Set<T>().Add(item);
        }

        public void Edit(T item)
        {
            Context.Entry(item).State = EntityState.Modified;
        }

        public T Find(int id)
        {
            return Context.Set<T>().Find(id);
        }

        public void Delete(T item)
        {
            Context.Entry(item).State = EntityState.Deleted;
        }

        public IQueryable<T> All()
        {
            return Context.Set<T>();
        }

        public void ReloadModel(T item)
        {
            Context.Entry(item).Reload();
        }

        #region IDisposable Support

        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (Context != null)
                    {
                        Context.Dispose();
                    }
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }

        #endregion IDisposable Support
    }
}