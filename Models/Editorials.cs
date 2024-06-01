using Books.Models;
namespace Editorials.Models;
using System.Text.Json.Serialization;


    public enum EditorialStatus
    {
        Inactive = 0,
        Active = 1
}
public class Editorial
{

    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public EditorialStatus? Status { get; set; }
    // Navegación de uno a muchos
    [JsonIgnore]
    public ICollection<Book> Books { get; set; } = new List<Book>();
}