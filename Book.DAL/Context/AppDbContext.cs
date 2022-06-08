using Books.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.DAL.Context
{
    public class AppDbContext:DbContext
    {
        public DbSet<Author> Authors{ get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BooksAuthors> BookAuthors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //set primary key
            modelBuilder.Entity<BooksAuthors>()
                        .HasKey(ba => new { ba.BookId, ba.AuthorId });

            //set foreign key
            modelBuilder.Entity<BooksAuthors>()
                        .HasOne(ba => ba.Book)
                        .WithMany(b => b.BooksAuthors)
                        .HasForeignKey(ba => ba.BookId);
            //set foreign key
            modelBuilder.Entity<BooksAuthors>()
                        .HasOne(ba => ba.Author)
                        .WithMany(b => b.BookAuthors)
                        .HasForeignKey(ba => ba.AuthorId);

            modelBuilder.Entity<Book>()
                        .HasOne(b => b.Genre)
                        .WithMany(g => g.Books)
                        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.ApplyConfiguration(new SeedData.SeedAuthors());
            modelBuilder.ApplyConfiguration(new SeedData.SeedBookAuthors());
            modelBuilder.ApplyConfiguration(new SeedData.SeedBooks());
            modelBuilder.ApplyConfiguration(new SeedData.SeedGenres());

            

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;
                                        Database=BooksSample;
                                        User Id=sa;
                                        password=123");
        }
    }
}
