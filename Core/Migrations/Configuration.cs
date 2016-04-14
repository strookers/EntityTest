using System.Globalization;

namespace Core.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Core.Entity.EntityData>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Core.Entity.EntityData context)
        {
            //This method will be called after migrating to the latest version.

            //You can use the DbSet<T>.AddOrUpdate() helper extension method
            //to avoid creating duplicate seed data.E.g.

            //context.Movies.AddOrUpdate(
            //  p => p.Name,
            //  new Movie { Id = new Guid("44e11b12-c9b7-44b2-8ef5-41c67fbe70ec"), Name = "Batman" },
            //  new Movie { Id = new Guid("f81df7ba-165a-40e6-88cd-cd7193a14f34"), Name = "Star Wars" }
            //);

            //context.Screens.AddOrUpdate(
            //    s => s.Name,
            //    new Screen { Id = new Guid("2b1e1e69-9f0a-41d3-9d63-d04cf97614dc"), Name = "sal 1" },
            //    new Screen { Id = new Guid("689c15e4-f631-468e-84e0-3d46cd49482b"), Name = "sal 2" }
            //    );

            //context.Shows.AddOrUpdate(
            //    x => x.Id,
            //    new Show { Id = new Guid("a1cd09de-9261-4966-98f4-af60603111e7"), MovieId = new Guid("44e11b12-c9b7-44b2-8ef5-41c67fbe70ec"), ScreenId = new Guid("2b1e1e69-9f0a-41d3-9d63-d04cf97614dc"), DateTime = DateTime.ParseExact("2016-12-06 22:14:23", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) }
            //    );
        }
    }
}
