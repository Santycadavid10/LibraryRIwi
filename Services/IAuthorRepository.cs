using Microsoft.AspNetCore.Mvc;

using Authors.Models;
    public interface IAuthorRepository
    {
          IEnumerable<Author> GetAll();//Listar todos los autores
        
          Author GetById(int id);//Listar un unico autor ID
          IActionResult Create(Author newAuthor);//Crear unnuevo autor

          IActionResult DeleteById(int id);  //Eliminar un autor por su ID
          IActionResult Update(int id, Author updatedAuthor); // método para actualizar un autor
          

    }