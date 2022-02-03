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
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId=1, CategoryName="Action/Sci-fi"},
                new Category { CategoryId=2, CategoryName="Adventure/Action"},
                new Category { CategoryId=3, CategoryName="Romance/War"},
                new Category { CategoryId=4, CategoryName="Comedy"},
                new Category { CategoryId=5, CategoryName="Horror"},
                new Category { CategoryId=6, CategoryName="Thriller"},
                new Category { CategoryId=7, CategoryName="Romance/Comedy"},
                new Category { CategoryId=8, CategoryName="Drama"},
                new Category { CategoryId=9, CategoryName="Other"}
                );


            mb.Entity<AppResponse>().HasData(

                new AppResponse
                {
                    MovieId = 1,
                    CategoryId = 1,
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
                    CategoryId = 2,
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
                    CategoryId = 3,
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
