using Authors.Models;
using Microsoft.AspNetCore.Mvc;
public class UpdateAuthorsController : ControllerBase
{
    //coneccion a AuthorRepository
    private readonly IAuthorRepository _authorRepository;

    public UpdateAuthorsController(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }
    //////////////////////////////////////////////////////////////////////////////////////////////////7
    //Método para Actualizar autor 
    [HttpPut("ActualizarAutor/{Id}")]
    public IActionResult Update(Author updatedAuthor)
    {
        if (updatedAuthor == null)
        {
            return NotFound();
        }

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var updatedEntity = _authorRepository.Update(updatedAuthor); ;
            return Ok(updatedEntity);
        }
        catch (ArgumentException ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    // Método para actualizar solo el estado del autor
    [HttpPut("ActualizarEstadoAutor/{id}")]
    public IActionResult UpdateStatus(int id, AuthorStatus isActive)
    {
        var updatedAuthor = _authorRepository.UpdateAuthorStatus(id, isActive);
        if (updatedAuthor == null)
        {
            return NotFound();
        }

        return Ok(updatedAuthor);
    }
}