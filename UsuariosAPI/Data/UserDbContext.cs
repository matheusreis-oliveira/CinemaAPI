using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using UsuariosApi.Models;

namespace UsuariosApi.Data
{
    public class UserDbContext : IdentityDbContext<CustomIdentityUserModel, IdentityRole<int>, int>
    {

        private IConfiguration _configuration;

        public UserDbContext(DbContextOptions<UserDbContext> opt, IConfiguration configuration) : base(opt)
        {
            _configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            CustomIdentityUserModel admin = new CustomIdentityUserModel
            {
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                Id = 99999
            };

            PasswordHasher<CustomIdentityUserModel> hasher = new PasswordHasher<CustomIdentityUserModel>();

            admin.PasswordHash = hasher.HashPassword(admin, _configuration.GetValue<string>("admininfo:password"));

            builder.Entity<CustomIdentityUserModel>().HasData(admin);

            builder.Entity<IdentityRole<int>>().HasData(new IdentityRole<int> { Id = 99999, Name = "admin", NormalizedName = "ADMIN" });

            builder.Entity<IdentityRole<int>>().HasData(new IdentityRole<int> { Id = 99997, Name = "regular", NormalizedName = "REGULAR" });

            builder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int> { RoleId = 99999, UserId = 99999 });
        }
    }
}