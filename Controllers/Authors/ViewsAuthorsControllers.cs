using Authors.Models;
using Microsoft.AspNetCore.Mvc;

public class ViewsAuthorsController : ControllerBase
{
  //coneccion a AuthorRepository
  private readonly IAuthorRepository _authorRepository;
  public ViewsAuthorsController(IAuthorRepository authorRepository)
  {
    _authorRepository = authorRepository;
  }
  //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
  // Listar todos los autores
  [HttpGet("ListarTodosLosAutores")]
  public IEnumerable<Author> GetAll()
  {
    return _authorRepository.GetAll();
  }
  /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
  // Listar autor por ID
  [HttpGet("ListarAutorPorId/{id}")]
  public ActionResult<Author> GetById(int id)
  {
    var author = _authorRepository.GetById(id);
    if (author == null)
    {
      return NotFound();
    }
    return Ok(author);
  }
  ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
  //Listar autores activos
  [HttpGet("ListarAutoresActivos")]
  public ActionResult<IEnumerable<Author>> GetActiveAuthors()
  {
    var activeAuthors = _authorRepository.GetActiveAuthors();
    return Ok(activeAuthors);
  }
  //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
  //listar autores inactivos
  [HttpGet("ListarAutoresInactivos")]
  public ActionResult<IEnumerable<Author>> GetInactiveAuthors()
  {
    var inactiveAuthors = _authorRepository.GetInactiveAuthors();
    return Ok(inactiveAuthors);
  }
  /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
  


}
