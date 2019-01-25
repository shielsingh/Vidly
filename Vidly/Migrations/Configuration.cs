namespace Vidly.Migrations
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Vidly.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Vidly.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Vidly.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            IdentityRole role = new IdentityRole() { Id = Guid.NewGuid().ToString(), Name = "SuperAdmin" };
            ApplicationUser user = new ApplicationUser()
            {
                Id = Guid.NewGuid().ToString(),
                AccessFailedCount = 0,
                Email = "superadmin@vidly.com",
                EmailConfirmed = true,
                LockoutEnabled = false,
                PasswordHash = "ANLXGxPTH2TTnzz1PyZvlRECuuYkgwuZZDPJeWzAhQtiKXuFFdqYOGzB4zOi8yOv3A==",
                PhoneNumberConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                TwoFactorEnabled = false,
                UserName = "superadmin@vidly.com"
            };
            IdentityUserRole userRole = new IdentityUserRole() { RoleId = role.Id, UserId = user.Id };
            user.Roles.Add(userRole);

            context.Roles.AddOrUpdate(x => x.Id, role);
            context.Users.AddOrUpdate(x => x.Id, user);
        }
    }
}
