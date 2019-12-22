using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovie.Data;
using System;
using System.Linq;

namespace RazorPagesMovie.Models
{
     public static class SeedData
     {
          public static void Initialize(IServiceProvider serviceProvider)
          {
               using(var context = new RazorPagesMovieContext(
                    serviceProvider.GetRequiredService<DbContextOptions<RazorPagesMovieContext>>()))
               {
                    //Look for any movie
                    if (context.Movie.Any())
                    {
                         return;
                    }

                    context.Movie.AddRange(
                         new Movie
                         {
                              Title = "When Harry Met Sally",
                              ReleaseDate = DateTime.Parse("1989-2-12"),
                              Genre = "Romantic Comedy",
                              Price = 7.99M,
                              Rating = "A"
                         },
                         new Movie
                         {
                              Title = "Ghostbusters ",
                              ReleaseDate = DateTime.Parse("1984-3-13"),
                              Genre = "Comedy",
                              Price = 8.99M,
                              Rating = "B"
                         },
                         new Movie
                         {
                              Title = "Ghostbusters 2",
                              ReleaseDate = DateTime.Parse("1986-2-23"),
                              Genre = "Comedy",
                              Price = 9.99M,
                              Rating = "A"
                         },
                         new Movie
                         {
                              Title = "Rio Bravo",
                              ReleaseDate = DateTime.Parse("1959-4-15"),
                              Genre = "Western",
                              Price = 3.99M,
                              Rating = "C"
                         },
                         new Movie
                         {
                              Title = "London's Query",
                              ReleaseDate = DateTime.Parse("1999-4-15"),
                              Genre = "Tragedy",
                              Price = 4.00M,
                              Rating = "A"
                         },
                         new Movie
                         {
                              Title = "Dance of the Leaf",
                              ReleaseDate = DateTime.Parse("2012-12-01"),
                              Genre = "Thriller",
                              Price = 1.99M,
                              Rating = "F"
                         },
                         new Movie
                         {
                              Title = "Jonhney Bravo",
                              ReleaseDate = DateTime.Parse("1959-4-15"),
                              Genre = "Comedy",
                              Price = 1.90M,
                              Rating = "B"
                         }
                    );
                    context.SaveChanges();
               }
          }
     }
}