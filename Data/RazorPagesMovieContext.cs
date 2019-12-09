using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie.Data
{
     class RazorPagesMovieContext : DbContext
     {
          public RazorPagesMovieContext (DbContextOptions<RazorPagesMovieContext> options)
          : base(options)
          {    
          }

          public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; }
     }
}