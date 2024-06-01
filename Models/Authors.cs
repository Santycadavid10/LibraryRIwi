using Books.Models;
using System.Text.Json.Serialization;


namespace Authors.Models;

public enum AuthorStatus
{
    Inactive = 0,
    Active = 1
}
public class Author
{

    public int Id { get; set; }
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Nationality { get; set; }
    public AuthorStatus? Status { get; set; }
    // Navegación de uno a muchos
    [JsonIgnore]
    public ICollection<Book> Books { get; set; } = new List<Book>();
}