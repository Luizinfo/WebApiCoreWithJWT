using System;
using System.Linq;
using WebApiCoreWithJWT.Models;

namespace WebApiCoreWithJWT.Infra.DataAccess.Repositories
{
    public interface IUserRepository : IRepositoryBase<User>, IDisposable
    {
        IQueryable<User> FindByFirstName(string FirstName);
    }
}