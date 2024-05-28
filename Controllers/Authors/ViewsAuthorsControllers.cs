using Authors.Models;
using Microsoft.AspNetCore.Mvc;

public class ViewsAuthorsnController : ControllerBase
{
  private readonly IAuthorRepository _authorRepository;

  public ViewsAuthorsnController(IAuthorRepository authorRepository)
  {
    _authorRepository = authorRepository;
  }
  public IEnumerable<Author> GetCoupons()
  {
    return _authorRepository.GetAll();
  }
}