namespace LmycWebSite.Migrations
{
    using LmycDataLib.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LmycDataLib.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LmycDataLib.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            /* context.Users.AddOrUpdate(
                u => u.Id, LmycDataLib.Data.DummyData.getUsers().ToArray()
                );
             */

            
            /*context.Boat.AddOrUpdate(
                b => b.BoatId, LmycDataLib.Data.DummyData.getBoats().ToArray()
                );
                */
                

            /*
            var hasher = new PasswordHasher();
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);

            context.Users.AddOrUpdate(u => u.UserName,
                new ApplicationUser
                {
                    UserName = "a",
                    PasswordHash = hasher.HashPassword("P@$$w0rd"),
                    Email = "a@a.a"
                });
            context.Users.AddOrUpdate(u => u.UserName,
              new ApplicationUser
              {
                  UserName = "b",
                  PasswordHash = hasher.HashPassword("P@$$w0rd"),
                  Email = "b@b.b"
              });

            */
             /*context.Roles.AddOrUpdate(r => r.Name,
                 new IdentityRole { Name = "admin" },
                 new IdentityRole { Name = "member" }
                 );
                 */
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);

            //UserManager.ChangePasswordAsync("91ca0335-4474-486a-b421-8018565d6c0b", "ANZD7p0zHekLvKkjPYC8Nkau17L/90iWIDCFXkv9qG07PzOk/65hCqC0A0QPyqfe6A==", "P@$$w0rd");

            userManager.AddToRole("47435e40-4a95-4d74-83ea-202ab99950cd", "admin");
            userManager.AddToRole("086a77d4-f536-4d62-ac1a-8c0f152fafdb", "member");
            
            /*
            var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            string[] roleNames = { "admin", "member" };
            IdentityResult roleResult;
            foreach (var roleName in roleNames)
            {
                if(!RoleManager.RoleExists(roleName))
                {
                    roleResult = RoleManager.Create(new IdentityRole(roleName));
                }
            }*/
        }
    }
}
