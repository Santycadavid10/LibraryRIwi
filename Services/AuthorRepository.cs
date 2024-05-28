using Authors.Models;
using Library.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuthorsRepository;
[Route("api/[controller]")]
[ApiController]
public class AuthorRepository : IAuthorRepository
{

    private readonly LibraryContext _context;
    public AuthorRepository(LibraryContext context)

    {
        _context = context;
    }

    [HttpGet]
    public IEnumerable<Author> GetAll()
    {
        return _context.Authors.ToList();
    }
}