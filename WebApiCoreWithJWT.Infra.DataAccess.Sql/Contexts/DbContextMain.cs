using Microsoft.EntityFrameworkCore;
using WebApiCoreWithJWT.Infra.DataAccess.Contexts;
using WebApiCoreWithJWT.Infra.DataAccess.Sql.EntityConfig;
using WebApiCoreWithJWT.Models;

namespace WebApiCoreWithJWT.Infra.DataAccess.Sql.Contexts
{
    public class DbContextMain : DbContext, IDbContextMain
    {
        public DbContextMain(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> User { get; private set; }

        public DbSet<Role> Role { get; private set; }

        public DbSet<Company> Company { get; private set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity(UserEntityConfig.Configure());
            modelBuilder.Entity(RoleEntityConfig.Configure());
            modelBuilder.Entity(CompanyEntityConfig.Configure());
        }
    }
}