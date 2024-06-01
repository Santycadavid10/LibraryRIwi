using Books.Models;
using Library.Data;

  public interface IBooksRepository
  {
    Task<List<Book>> GetAllBooks();
    Task<List<Book>> GetAllBooksWithAuthorsAndEditorialsAsync();
  }