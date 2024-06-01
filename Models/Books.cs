using Authors.Models;
using Editorials.Models;

namespace Books.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Pages { get; set; }
        public string? Languages { get; set; }
        public DateTime PublicationDate { get; set; }
        public string? Description { get; set; }

        // Claves foráneas
        public int AuthorId { get; set; }
        public Author? Author { get; set; }

        public int EditorialId { get; set; }
        public Editorial? Editorial { get; set; }
    }
}