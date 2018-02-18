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
            /*
            context.Users.AddOrUpdate(
                u => u.Id, LmycDataLib.Data.DummyData.getUsers().ToArray()
                );

            context.Boat.AddOrUpdate(
               b => b.BoatId, LmycDataLib.Data.DummyData.getBoats().ToArray()
               );
               */

            context.Roles.AddOrUpdate(r => r.Name,
                new IdentityRole { Name = "admin" },
                new IdentityRole { Name = "member" }
                );
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);
            userManager.AddToRole("55dad0b7-e24a-4672-bbdf-f0bf647941af", "admin");
            userManager.AddToRole("f1100270-fa24-4f98-b1d1-17ba48b4acfb", "member");

        }
    }
}
