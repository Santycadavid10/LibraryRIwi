namespace Authors.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

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
}