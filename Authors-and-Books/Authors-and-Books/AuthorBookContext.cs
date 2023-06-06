using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Authors_and_Books;
using Authors_and_Books.Entities;
using Microsoft.EntityFrameworkCore;

//AuthorBookContext context = new();
//await context.Database.MigrateAsync();

namespace Authors_and_Books
{
    public class AuthorBookContext:DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-EN11G01\SQLEXPRESS;Database=AuthorBookDb;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorBook>()
                .HasKey(ab => new { ab.AuthorId, ab.BookId });
            modelBuilder.Entity<AuthorBook>()
                .HasOne(ab=> ab.Book)
                .WithMany(b => b.Authors)
                .HasForeignKey(ab => ab.BookId);
            modelBuilder.Entity<AuthorBook>()
                .HasOne(ab => ab.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(ab => ab.AuthorId);
        }
    }
    
}
