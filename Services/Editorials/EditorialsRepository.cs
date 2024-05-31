using Editorials.Models;
using Library.Data;

public class EditorialsRepository : IEditorialsRepository
{
    //coneccion ala data
    private readonly LibraryContext _context;
    public EditorialsRepository(LibraryContext context)
    {
        _context = context;
    }

    //Listar todos las Editoriales
    public IEnumerable<Editorial> GetAll()
    {
        return _context.Editorials.ToList();
    }
    ////////////////////////////////////////////////////////////////////////////////////////////////////////
    // LISTAR UN USUARIO POR ID
    public Editorial GetById(int id)
    {
        return _context.Editorials.Find(id);
    }
    //////////////////////////////////////////////////////////////////////////////////////
    //LISTAR  LOS autores activos
    public IEnumerable<Editorial> GetActiveEditorial()
    {
        return _context.Editorials.Where(a => a.Status == EditorialStatus.Active).ToList();
    }
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //listar los autores inactivos
    public IEnumerable<Editorial> GetInactiveEditorials()
    {
        return _context.Editorials.Where(a => a.Status == EditorialStatus.Inactive).ToList();
    }
    ////////////////////////////////////////////////////////////////////////////////////////////

    // CREAR UN NUEVO AUTOR
    public Editorial Create(Editorial editorial)
    {
        _context.Editorials.Add(editorial);
        _context.SaveChanges();
        return editorial;
    }
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    
}