namespace WebApiBasics.Application.Services
{
  using System.Collections.Generic;
  using System.Threading.Tasks;
  using WebApiBasics.Models;

  public class BookService : IBookService
  {
    private readonly List<Book> currentBooks = new();

    public async Task AddBook(Book bookToAdd)
    {
      this.currentBooks.Add(bookToAdd);
    }

    public async Task<IEnumerable<Book>> GetAllBooks(string searchString = "")
    {
      var searchCase = StringComparison.OrdinalIgnoreCase;

      return this.currentBooks.Where(x
        => string.IsNullOrEmpty(searchString) || (x.Genre.Contains(searchString, searchCase) | x.Title.Contains(searchString, searchCase) | x.Author.Contains(searchString, searchCase)));
    }

    public async Task<Book> GetBookById(int bookId)
    {
      return this.currentBooks.FirstOrDefault(x => x.BookId == bookId);
    }

    public async Task RemoveBookById(int bookId)
    {
      var bookToDelete = await this.GetBookById(bookId);

      this.currentBooks.Remove(bookToDelete);
    }

    public async Task UpdateBook(Book bookToUpdate)
    {
      var book = await this.GetBookById(bookToUpdate.BookId);
      book.UpdateBook(bookToUpdate);
    }
  }
}