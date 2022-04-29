namespace OOD_S00200293_PersonalProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OOD_S00200293_PersonalProject.Movie.MovieData>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "OOD_S00200293_PersonalProject.Movie+MovieData";
        }

        protected override void Seed(OOD_S00200293_PersonalProject.Movie.MovieData context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
