using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebApiCoreWithJWT.Infra.DataAccess.Sql.Contexts;
using WebApiCoreWithJWT.Infra.DataAccess.UnitOfWork;

namespace WebApiCoreWithJWT.Infra.DataAccess.Sql.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private IDbContextMain context;
        public UnitOfWork(IDbContextMain context)
        {
            this.context = context;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public void SetTimeOut(int timeOutInSeconds = 180)
        {
            throw new NotImplementedException();
        }
    }
}
