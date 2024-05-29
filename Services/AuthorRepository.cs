using Authors.Models;
using Library.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuthorsRepository;
[Route("api/[controller]")]
[ApiController]
public class AuthorRepository : ControllerBase, IAuthorRepository
{
    private readonly LibraryContext _context;
    public AuthorRepository(LibraryContext context)

    {
        _context = context;
    }

//LISTAR TODOS LOS USUARIOS
    [HttpGet]
    public IEnumerable<Author> GetAll()
    {
        return _context.Authors.ToList();
    }

//lISTAR UN USUARIO POR iD
    [HttpGet("{id}")]
    public ActionResult<Author> GetById(int id)
    {
        var author = _context.Authors.Find(id);
        if (author == null)
        {
            return NotFound();
        }
        return author;
    }

// MÉTODO PARA ELIMINAR UN AUTOR POR ID
    [HttpDelete("{id}")]
    public IActionResult DeleteById(int id)
    {
        var author = _context.Authors.Find(id);
        if (author == null)
        {
            return NotFound();
        }
        _context.Authors.Remove(author);
        _context.SaveChanges();
        return NoContent(); // Respuesta 204 No Content para indicar que la eliminación fue exitosa
        }

//METODO PARA AGREGAR UN AUTOR 
    [HttpPost]
    public IActionResult Create(Author newAuthor)
    {
        if (newAuthor == null)
        {
            return BadRequest();
        }
        _context.Authors.Add(newAuthor);
        _context.SaveChanges();
        // Retornar un CreatedAtAction con la URI del nuevo recurso
        return CreatedAtAction(nameof(GetById), new { id = newAuthor.Id }, newAuthor);
    }

//metodo para actualizar 
[HttpPut("{id}")] // Usar HttpPut para actualizar un recurso
        public IActionResult Update(int id, Author updatedAuthor)
        {
            var author = _context.Authors.Find(id);
            if (author == null)
            {
                return NotFound();
            }

            // Actualizar los campos del autor existente con los datos proporcionados en updatedAuthor
            // Actualizar los campos del autor existente con los datos proporcionados en updatedAuthor
    if (updatedAuthor.Name != null)
    {
        author.Name = updatedAuthor.Name;
    }

    if (updatedAuthor.LastName != null)
    {
        author.LastName = updatedAuthor.LastName;
    }

    if (updatedAuthor.Email != null)
    {
        author.Email = updatedAuthor.Email;
    }

    if (updatedAuthor.Nationality != null)
    {
        author.Nationality = updatedAuthor.Nationality;
    }
            // Actualizar otros campos si es necesario

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AuthorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent(); // Devolver un resultado de "No Content" para indicar que la actualización fue exitosa
        }

        private bool AuthorExists(int id)
        {
            return _context.Authors.Any(e => e.Id == id);
        }


    Author IAuthorRepository.GetById(int id)
    {
        throw new NotImplementedException();
    }
}