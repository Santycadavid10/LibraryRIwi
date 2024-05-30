using Microsoft.AspNetCore.Mvc;

using Authors.Models;



  public interface IAuthorRepository
  {
    IEnumerable<Author> GetAll();//Listar todos los autores

    Author GetById(int id);//Listar un unico autor ID

    Author Create(Author author); // Crear un nuevo autor

    Author Update(Author updatedAuthor); // Actualizar un autor existente y devolver el autor actualizado

    Author Delete(int id); // Eliminar un autor por su ID

    Author UpdateAuthorStatus(int id, AuthorStatus isActive); // Método para actualizar el estado de un autor por su ID
  }





