using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models;

public record Book
{
    public int Id { get; init; }

    [Required]
    [StringLength(100)]
    public string Title { get; init; } = string.Empty;

    [Required]
    [StringLength(50)]
    public string Author { get; init; } = string.Empty;

    public Book() { }

    public Book(int id, string title, string author)
    {
        Id = id;
        Title = title;
        Author = author;
    }
}
