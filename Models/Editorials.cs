namespace Editorials.Models;

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
}