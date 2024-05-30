using Microsoft.AspNetCore.Mvc;
public class DeleteAuthorsController : ControllerBase
{
    //coneccion a AuthorRepository
    private readonly IAuthorRepository _authorRepository;

    public DeleteAuthorsController(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //eliminar por su ID
    [HttpDelete("EliminarAutor/{id}")]
    public IActionResult Delete(int id)
    {
        try
        {
            var deletedAuthor = _authorRepository.Delete(id);

            if (deletedAuthor != null)
            {
                return Ok(deletedAuthor); // Devuelve el autor eliminado si se encontró y eliminó con éxito
            }
            else
            {
                return NotFound(); // Devuelve un error 404 si no se encontró el autor
            }
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message); // Devuelve un error 500 si ocurre algún problema durante la eliminación
        }
    }
}