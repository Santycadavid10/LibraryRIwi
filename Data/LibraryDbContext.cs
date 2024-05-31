using Microsoft.EntityFrameworkCore;
using Authors.Models;
using Editorials.Models;


namespace Library.Data;
public class LibraryContext : DbContext
{
    public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
    {
    }
    public DbSet<Author> Authors{ get; set; }
     
    public DbSet<Editorial> Editorials{ get; set; }
    
    }
