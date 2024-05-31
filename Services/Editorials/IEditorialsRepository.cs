using Editorials.Models;

    public interface IEditorialsRepository
    {
        IEnumerable<Editorial> GetAll();//Listar todos los autores

        Editorial GetById(int id);//Listar un unico autor ID

        IEnumerable<Editorial> GetActiveEditorial();//Listar todos los autores

        IEnumerable<Editorial> GetInactiveEditorials(); // Método para obtener autores inactivos
        Editorial Create(Editorial author); // Crear un nuevo autor


    }