using Microsoft.EntityFrameworkCore;
using Authors.Models;


namespace Library.Data;
public class LibraryContext : DbContext
{
    public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
    {
    }
    public DbSet<Author> Authors{ get; set; }
     }
