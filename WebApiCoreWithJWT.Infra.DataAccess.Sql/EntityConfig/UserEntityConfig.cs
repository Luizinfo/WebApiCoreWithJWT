using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using WebApiCoreWithJWT.Models;

namespace WebApiCoreWithJWT.Infra.DataAccess.Sql.EntityConfig
{
    internal class UserEntityConfig
    {
        internal static Action<EntityTypeBuilder<User>> Configure()
        {
            return (entity) =>
            {
                entity.ToTable("User");

                entity.HasKey(c => c.Id);
                entity.Property(c => c.Id).ValueGeneratedOnAdd();

                entity.Property(c => c.FirstName).IsRequired().HasMaxLength(50);
                entity.Property(c => c.Password).IsRequired().HasMaxLength(50);
                entity.Property(c => c.Username).IsRequired().HasMaxLength(50);
                entity.Property(c => c.RoleId).IsRequired();
                entity.Property(c => c.CompanyId).IsRequired();

                entity.HasOne(c => c.Role)
                .WithMany(c => c.Users)
                .HasForeignKey(c => c.RoleId)
                .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(c => c.Company)
                .WithMany(c => c.Users)
                .HasForeignKey(c => c.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);

                entity.HasIndex(c => new { c.Username, c.Password });
                entity.HasIndex(c => c.Username).IsUnique();

                entity.Ignore(c => c.Token);
                entity.Ignore(c => c.TokenExpiration);
            };
        }
    }
}