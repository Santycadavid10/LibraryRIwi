using Books.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class BooksController : ControllerBase
{
    private readonly IBooksRepository _booksRepository;

    public BooksController(IBooksRepository booksRepository)
    {
        _booksRepository = booksRepository;
    }

    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    // Listar todos los autores
     [HttpGet]
    public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
    {
    var booksWithAuthorsAndEditorials = await _booksRepository.GetAllBooksWithAuthorsAndEditorialsAsync();

    return Ok(booksWithAuthorsAndEditorials);
    }
}