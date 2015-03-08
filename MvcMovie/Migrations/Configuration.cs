namespace MvcMovie.Migrations
{
    using MvcMovie.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovie.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MvcMovie.Models.MovieDBContext";
        }

        protected override void Seed(MvcMovie.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title,
                new Movie
                {
                    Title = "I'm Gonna Git you Sucka",
                    ReleaseDate = DateTime.Parse("1989-1-11"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 7.99M
                },

                new Movie
                {
                    Title = "Malcolm X",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Drama",
                    Rating = "R",
                    Price = 8.99M
                },

                new Movie
                {
                    Title = "Mo Better Blues",
                    ReleaseDate = DateTime.Parse("1992-3-23"),
                    Genre = "Musical",
                    Rating = "R",
                    Price = 9.99M
                },

                new Movie
                {
                    Title = "Selma",
                    ReleaseDate = DateTime.Parse("2014-11-10"),
                    Genre = "Action",
                    Rating = "PG-13",
                    Price = 15.99M
                }

           );
        }
    }
}
