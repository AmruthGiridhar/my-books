using Microsoft.EntityFrameworkCore;
using my_books.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<book_Author>()
                .HasOne(b => b.book)
                .WithMany(ba => ba.book_Authors)
                .HasForeignKey(bi => bi.bookId);

            modelBuilder.Entity<book_Author>()
                .HasOne(b => b.author)
                .WithMany(ba => ba.book_Authors)
                .HasForeignKey(bi => bi.authorId);
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<publisher> publishers { get; set; }
        public DbSet<book_Author> books_Authors { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
