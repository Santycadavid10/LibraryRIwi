using Authors.Models;
using Microsoft.AspNetCore.Mvc;

public class DelateAuthorsnController : ControllerBase
{
    private readonly IAuthorRepository _authorRepository;

    public DelateAuthorsnController(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }
}