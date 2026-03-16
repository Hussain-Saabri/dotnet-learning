namespace WebAPI.DTOs;

public record BookDto(int Id, string Title, string Author);

public record CreateBookDto(string Title, string Author);
