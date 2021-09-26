using SimbaLibrary.App.Brokers.Storages;
using SimbaLibrary.App.Models.Books;

namespace SimbaLibrary.App.Services.Foundations.Books
{
    public class BookService : IBookService
    {
        private readonly IStorageBroker storageBroker;

        public BookService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;
        public Book AddBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
