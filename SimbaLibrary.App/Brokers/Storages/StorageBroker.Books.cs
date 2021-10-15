using SimbaLibrary.App.Models.Books;

namespace SimbaLibrary.App.Brokers.Storages
{
    public partial class StorageBroker
    {
        List<Book> books = new List<Book>();

        public Book InsertBook(Book book)
        {
            books.Add(book);

            return book;
        }

        public List<Book> SelectAllBooks() => books;
        public Book SelectBookById(Guid id) =>
            books.Find(book => book.Id == id);
        public Book UpdateBook(Book book)
        {
            books.RemoveAll(book => book.Id == book.Id);
            books.Add(book);

            return book;
        }

        public Book DeleteBook(Book book)
        {
            books.Remove(book);

            return book;
        }
    }
}
