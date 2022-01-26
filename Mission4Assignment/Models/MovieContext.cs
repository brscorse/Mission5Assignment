using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4Assignment.Models
{
    public class MovieContext : DbContext
    {
        //Constructor
        public MovieContext (DbContextOptions<MovieContext> options) : base (options)
        {
            //Blank
        }

        public DbSet<AppResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<AppResponse>().HasData(

                new AppResponse
                {
                    MovieId = 1,
                    Category = "Action/Sci-Fi",
                    Title = "Inception",
                    Year = 2010,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    Lent = "",
                    Notes = ""
                },
                new AppResponse
                {
                    MovieId = 2,
                    Category = "Adventure/Action",
                    Title = "Pirates of the Carribbean: The Curse of the Black Pearl",
                    Year = 2003,
                    Director = "Gore Verbinski",
                    Rating = "PG-13",
                    Edited = false,
                    Lent = "",
                    Notes = ""
                },
                new AppResponse
                {
                    MovieId = 3,
                    Category = "Romance/War",
                    Title = "Gone with the Wind",
                    Year = 1939,
                    Director = "Victor Fleming",
                    Rating = "PG-13",
                    Edited = false,
                    Lent = "",
                    Notes = ""
                }
            );
        }
    }
}
