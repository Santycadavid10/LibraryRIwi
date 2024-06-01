using System.Collections.Generic;
using System.Threading.Tasks;
using Books.Models;
using Library.Data;
using Microsoft.EntityFrameworkCore;

public class BooksRepository : IBooksRepository
{
    private readonly LibraryContext _context;

    public BooksRepository(LibraryContext context)
    {
        _context = context;
    }

    public async Task<List<Book>> GetAllBooks()
    {
        return await _context.Books.ToListAsync();
    }

    public async Task<List<Book>> GetAllBooksWithAuthorsAndEditorialsAsync()
    {
        return await _context.Books
            .Include(book => book.Author)
            .Include(book => book.Editorial)
            .ToListAsync();
    }
}