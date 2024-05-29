using Authors.Models;
using Microsoft.AspNetCore.Mvc;

public class ViewsAuthorsnController : ControllerBase
{
  private readonly IAuthorRepository _authorRepository;

  public ViewsAuthorsnController(IAuthorRepository authorRepository)
  {
    _authorRepository = authorRepository;
  }



  //Listar Authores
  public IEnumerable<Author> GetCoupons()
  {
    return _authorRepository.GetAll();
  }


  

//listar Atuthor por ID detalles
  public Author Details(int id)
  {
    return _authorRepository.GetById(id);
  }  
}