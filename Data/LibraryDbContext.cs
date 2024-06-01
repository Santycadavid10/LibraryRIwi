using Microsoft.EntityFrameworkCore;
using Authors.Models;
using Editorials.Models;
using Books.Models;
using System.Linq;



namespace Library.Data;
public class LibraryContext : DbContext
{
    public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
    {
    }
    public DbSet<Author> Authors{ get; set; }
     
    public DbSet<Editorial> Editorials{ get; set; }

     public DbSet<Book> Books { get; set; }


      protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>()
            .HasOne(b => b.Author)
            .WithMany(a => a.Books)
            .HasForeignKey(b => b.AuthorId);

        modelBuilder.Entity<Book>()
            .HasOne(b => b.Editorial)
            .WithMany(e => e.Books)
            .HasForeignKey(b => b.EditorialId);
    }
    
    }
