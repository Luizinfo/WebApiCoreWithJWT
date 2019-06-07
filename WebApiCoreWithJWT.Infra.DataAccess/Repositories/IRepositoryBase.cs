using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApiCoreWithJWT.Infra.DataAccess.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        void Add(T item);

        T Find(int id);

        void Edit(T item);

        void Delete(T item);

        IQueryable<T> All();

        void ReloadModel(T item);
    }
}
