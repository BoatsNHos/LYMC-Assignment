namespace lymcAssignment.Migrations.Boats
{
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
            context.Users.AddOrUpdate(
                u => u.Id, LmycDataLib.Data.DummyData.getUsers().ToArray()
                );

            context.Boats.AddOrUpdate(
                b => b.BoatId, LmycDataLib.Data.DummyData.getBoats().ToArray()
                );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
