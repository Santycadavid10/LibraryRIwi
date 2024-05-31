using Authors.Models;
using Library.Data;

public class AuthorRepository : IAuthorRepository
{
    //coneccion ala data
    private readonly LibraryContext _context;
    public AuthorRepository(LibraryContext context)
    {
        _context = context;
    }

    //LISTAR TODOS LOS USUARIOS
    public IEnumerable<Author> GetAll()
    {
        return _context.Authors.ToList();
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////7

    // LISTAR UN USUARIO POR ID
    public Author GetById(int id)
    {
        return _context.Authors.Find(id);
    }
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    //LISTAR  LOS autores activos
    public IEnumerable<Author> GetActiveAuthors()
    {
        return _context.Authors.Where(a => a.Status == AuthorStatus.Active).ToList();
    }
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //listar los autores inactivos
    public IEnumerable<Author> GetInactiveAuthors()
        {
            return _context.Authors.Where(a => a.Status == AuthorStatus.Inactive).ToList();
        }
    ////////////////////////////////////////////////////////////////////////////////////////////


    // CREAR UN NUEVO AUTOR
    public Author Create(Author author)
    {
        _context.Authors.Add(author);
        _context.SaveChanges();
        return author;
    }
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    // Actualizar un autor existente y devolver el autor actualizado
    public Author Update(Author updatedAuthor)
    {
        var existingAuthor = _context.Authors.Find(updatedAuthor.Id);
        if (existingAuthor == null)
        {
            throw new ArgumentException("El autor no existe");
        }
        // Actualizar solo los campos que no son nulos en el objeto updatedAuthor
        if (updatedAuthor.Name != null)
        {
            existingAuthor.Name = updatedAuthor.Name;
        }

        if (updatedAuthor.LastName != null)
        {
            existingAuthor.LastName = updatedAuthor.LastName;
        }

        if (updatedAuthor.Email != null)
        {
            existingAuthor.Email = updatedAuthor.Email;
        }

        if (updatedAuthor.Nationality != null)
        {
            existingAuthor.Nationality = updatedAuthor.Nationality;
        }
        // Guardar los cambios en la base de datos
        _context.SaveChanges();
        return existingAuthor;
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    //Actualizar SOLO EL  estado del autor 
    public Author UpdateAuthorStatus(int id, AuthorStatus isActive)
    {
        var author = _context.Authors.Find(id);
        if (author == null)
        {
            return null;
        }
        author.Status = isActive;
        _context.SaveChanges();
        return author;
    }
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    // Eliminar un autor
    public Author Delete(int id)
    {
        var authorToDelete = _context.Authors.Find(id);

        if (authorToDelete != null)
        {
            _context.Authors.Remove(authorToDelete);
            _context.SaveChanges();
        }

        return authorToDelete; // Devuelve el autor eliminado o null si no se encontró
    }
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////    
}
