namespace WebApiBasics.Application.Services
{
  using System.Collections.Generic;
  using System.Threading.Tasks;

  public interface IBookService
  {
    Task AddBook(Book bookToAdd);

    Task<IEnumerable<Book>> GetAllBooks(string searchString = "");

    Task RemoveBookById(int bookId);

    Task<Book> GetBookById(int bookId);

    Task UpdateBook(Book bookToUpdate);
  }
}
