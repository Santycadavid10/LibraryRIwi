using Authors.Models;
using Microsoft.AspNetCore.Mvc;
public class CreateAuthorsController : ControllerBase
{
    //coneccion a AuthorRepository
    private readonly IAuthorRepository _authorRepository;
    public CreateAuthorsController(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    // Crear un nuevo autor
    [HttpPost("CrearAutor")]
    public ActionResult<Author> Create(Author author)
    {
        _authorRepository.Create(author);
        return CreatedAtAction("GetById", "ViewsAuthors", new { id = author.Id }, author);//RETORNO EL AUTOR CREADO Y LLAMO AL METODO GetById
    }
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////7
}