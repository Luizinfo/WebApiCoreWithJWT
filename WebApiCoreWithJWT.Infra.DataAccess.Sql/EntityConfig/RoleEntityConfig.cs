using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using WebApiCoreWithJWT.Models;

namespace WebApiCoreWithJWT.Infra.DataAccess.Sql.EntityConfig
{
    internal class RoleEntityConfig
    {
        internal static Action<EntityTypeBuilder<Role>> Configure()
        {
            return (entity) =>
            {
                entity.ToTable("Role");

                entity.HasKey(c => c.Id);
                entity.Property(c => c.Id).ValueGeneratedOnAdd();

                entity.Property(c => c.Name).IsRequired().HasMaxLength(50);

                entity.HasMany(c => c.Users)
                .WithOne(c => c.Role);
            };
        }
    }
}