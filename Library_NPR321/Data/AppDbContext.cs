using Library_NPR321.Models;
using Microsoft.EntityFrameworkCore;

namespace Library_NPR321.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Authors
            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    Id = 1,
                    FirstName = "Джоан",
                    LastName = "Роулінг",
                    Birthday = new DateTime(1965, 7, 31)
                },
                new Author
                {
                    Id = 2,
                    FirstName = "Джон Рональд Руел",
                    LastName = "Толкін",
                    Birthday = new DateTime(1892, 1, 3)
                },
                new Author
                {
                    Id = 3,
                    FirstName = "Стівен",
                    LastName = "Кінг",
                    Birthday = new DateTime(1947, 9, 21)
                }
                );

            // Books
        }
    }
}
