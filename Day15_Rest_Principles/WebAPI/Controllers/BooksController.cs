using Microsoft.AspNetCore.Mvc;
using WebAPI.DTOs;
using WebAPI.Services;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BooksController : ControllerBase
{
    private readonly IBookService _bookService;
    private readonly ILogger<BooksController> _logger;

    public BooksController(IBookService bookService, ILogger<BooksController> logger)
    {
        _bookService = bookService;
        _logger = logger;
    }

    // GET: api/books
    [HttpGet]
    public ActionResult<IEnumerable<BookDto>> Get()
    {
        _logger.LogInformation("Retrieving all books");
        var books = _bookService.GetAllBooks();
        return Ok(books);
    }

    // GET: api/books/1
    [HttpGet("{id}")]
    public ActionResult<BookDto> Get(int id)
    {
        _logger.LogInformation("Retrieving book with ID {Id}", id);
        var book = _bookService.GetBookById(id);
        
        if (book == null)
        {
            _logger.LogWarning("Book with ID {Id} not found", id);
            return NotFound(new { Message = $"Book with ID {id} not found" });
        }
        
        return Ok(book);
    }

    // POST: api/books
    [HttpPost]
    public ActionResult<BookDto> Post([FromBody] CreateBookDto createBookDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _logger.LogInformation("Creating a new book: {Title}", createBookDto.Title);
        var createdBook = _bookService.CreateBook(createBookDto);

        return CreatedAtAction(nameof(Get), new { id = createdBook.Id }, createdBook);
    }
}
