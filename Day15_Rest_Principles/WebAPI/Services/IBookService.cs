using WebAPI.DTOs;

namespace WebAPI.Services;

public interface IBookService
{
    IEnumerable<BookDto> GetAllBooks();
    BookDto? GetBookById(int id);
    BookDto CreateBook(CreateBookDto createBookDto);
}
