using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TheUnoBooks.Data;
using System;
using System.Linq;

namespace TheUnoBooks.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TheUnoBooksContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TheUnoBooksContext>>()))
            {
                // Look for any movies.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        Title = "Pride And Prejudice",
                        PublishDate = DateTime.Parse("1813-1-28"),
                        Author = "Jane Austen",
                        Genre = "Romance, Drama",
                        Price = 20.08M
                    },

                    new Book
                    {
                        Title = "The Silent Patient",
                        PublishDate = DateTime.Parse("2019-2-5"),
                        Author = "Alex Michaelides",
                        Genre = "Thriller",
                        Price = 13.99M
                    },

                    new Book
                    {
                        Title = "The Guest List",
                        PublishDate = DateTime.Parse("2020-2-20"),
                        Author = "Lucy Foley",
                        Genre = "Mystery",
                        Price = 11.99M
                    },

                    new Book
                    {
                        Title = "Nimona",
                        PublishDate = DateTime.Parse("1959-4-15"),
                        Author = "ND Stevenson",
                        Genre = "Comic",
                        Price = 3.99M
                    },

                    new Book
                    {
                        Title = "After Series",
                        PublishDate = DateTime.Parse("2014-10-21"),
                        Author = "Anna Todd",
                        Genre = "Romantic Fiction",
                        Price = 109.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}