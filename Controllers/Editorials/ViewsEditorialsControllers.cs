using Editorials.Models;
using Microsoft.AspNetCore.Mvc;

public class ViewsEditorialsController : ControllerBase
{
    //coneccion a AuthorRepository
    private readonly IEditorialsRepository _editorialsRepository;
    public ViewsEditorialsController(IEditorialsRepository editorialsRepository)
    {
        _editorialsRepository = editorialsRepository;
    }
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    // Listar todos los autores
    [HttpGet("ListarTodosLasEditoriales")]
    public IEnumerable<Editorial> GetAll()
    {
        return _editorialsRepository.GetAll();
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
    // Listar autor por ID
    [HttpGet("ListarEditorialPorId/{id}")]
    public ActionResult<Editorial> GetById(int id)
    {
        var editorial = _editorialsRepository.GetById(id);
        if (editorial == null)
        {
            return NotFound();
        }
        return Ok(editorial);
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //Listar autores activos
    [HttpGet("ListarEditorialesActivos")]
    public ActionResult<IEnumerable<Editorial>> GetActiveEditorial()
    {
        var GetActiveEditorial = _editorialsRepository.GetActiveEditorial();
        return Ok(GetActiveEditorial);
    }
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //listar autores inactivos
    [HttpGet("ListarEditorialesInactivos")]
    public ActionResult<IEnumerable<Editorial>> GetInactiveEditorials()
    {
        var GetInactiveEditorial = _editorialsRepository.GetInactiveEditorials();
        return Ok(GetInactiveEditorial);
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    // Crear un nuevo autor
    [HttpPost("CrearEditorial")]
    public ActionResult<Editorial> Create(Editorial editorial)
    {
        _editorialsRepository.Create(editorial);
        return GetById(editorial.Id);//RETORNO EL AUTOR CREADO Y LLAMO AL METODO GetById
    }
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////7

}