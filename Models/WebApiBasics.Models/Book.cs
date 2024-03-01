namespace WebApiBasics.Models
{
  public class Book
  {
    public int BookId { get; set; }

    public string Title { get; set; }

    public string Genre { get; set; }

    public string Author { get; set; }

    public int NumberOfPages { get; set; }

    public void UpdateBook(Book updatedValues)
    {
      if (!string.IsNullOrEmpty(updatedValues.Title))
      {
        this.Title = updatedValues.Title;
      }

      if (!string.IsNullOrEmpty(updatedValues.Genre))
      {
        this.Genre = updatedValues.Genre;
      }

      if (!string.IsNullOrEmpty(updatedValues.Author))
      {
        this.Author = updatedValues.Author;
      }

      if (updatedValues.NumberOfPages > 0)
      {
        this.NumberOfPages = updatedValues.NumberOfPages;
      }
    }
  }
}
