using WebAPI.DTOs;
using WebAPI.Models;

namespace WebAPI.Services;

public class BookService : IBookService
{
    private static readonly List<Book> _books = new()
    {
        new(1, "The Great Gatsby", "F. Scott Fitzgerald"),
        new(2, "1984", "George Orwell"),
        new(3, "The Catcher in the Rye", "J.D. Salinger")
    };

    public IEnumerable<BookDto> GetAllBooks()
    {
        return _books.Select(b => new BookDto(b.Id, b.Title, b.Author));
    }

    public BookDto? GetBookById(int id)
    {
        var book = _books.FirstOrDefault(b => b.Id == id);
        return book != null ? new BookDto(book.Id, book.Title, book.Author) : null;
    }

    public BookDto CreateBook(CreateBookDto createDto)
    {
        var id = _books.Count > 0 ? _books.Max(b => b.Id) + 1 : 1;
        var book = new Book(id, createDto.Title, createDto.Author);
        _books.Add(book);
        
        return new BookDto(book.Id, book.Title, book.Author);
    }
}
