﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission4Assignment.Models;

namespace Mission4Assignment.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission4Assignment.Models.AppResponse", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lent")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryId = 1,
                            Director = "Christopher Nolan",
                            Edited = false,
                            Lent = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Inception",
                            Year = 2010
                        },
                        new
                        {
                            MovieId = 2,
                            CategoryId = 2,
                            Director = "Gore Verbinski",
                            Edited = false,
                            Lent = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Pirates of the Carribbean: The Curse of the Black Pearl",
                            Year = 2003
                        },
                        new
                        {
                            MovieId = 3,
                            CategoryId = 3,
                            Director = "Victor Fleming",
                            Edited = false,
                            Lent = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Gone with the Wind",
                            Year = 1939
                        });
                });

            modelBuilder.Entity("Mission4Assignment.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Action/Sci-fi"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Adventure/Action"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Romance/War"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Horror"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Thriller"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Romance/Comedy"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryId = 9,
                            CategoryName = "Other"
                        });
                });

            modelBuilder.Entity("Mission4Assignment.Models.AppResponse", b =>
                {
                    b.HasOne("Mission4Assignment.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
