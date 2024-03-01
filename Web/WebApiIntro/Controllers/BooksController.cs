namespace WebApiIntro.Controllers
{
  using Microsoft.AspNetCore.Mvc;
  using WebApiBasics.Application.Services;

  [Route("[controller]/[action]")]
  [ApiController]
  public class BooksController : ControllerBase
  {
    private readonly IBookService bookService;

    public BooksController(IBookService bookService)
    {
      this.bookService = bookService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllBooks(string searchString = "")
    {
      var books = await this.bookService.GetAllBooks(searchString);

      return this.Ok(books);
    }
  }
}