using SimbaLibrary.App.Models.Books;

namespace SimbaLibrary.App.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        Book InsertBook(Book book);
        List<Book> GetAllBooks();
        Book GetBookById(Guid id);
        Book UpdateBook(Book book);
        Book DeleteBook(Book book);
    }
}
