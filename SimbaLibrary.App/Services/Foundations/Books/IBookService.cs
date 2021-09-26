using SimbaLibrary.App.Models.Books;

namespace SimbaLibrary.App.Services.Foundations.Books
{
    public interface IBookService
    {
        public Book AddBook(Book book);
    }
}
