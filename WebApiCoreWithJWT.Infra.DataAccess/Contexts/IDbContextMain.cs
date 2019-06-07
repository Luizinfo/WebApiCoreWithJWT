using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApiCoreWithJWT.Models;

namespace WebApiCoreWithJWT.Infra.DataAccess.Contexts
{
    public interface IDbContextMain
    {
        DbSet<User> User { get; }
        DbSet<Role> Role { get; }
        DbSet<Company> Company { get; }
    }
}
