using Moq;
using SimbaLibrary.App.Brokers.Storages;
using SimbaLibrary.App.Services.Foundations.Books;

namespace SimbaLibrary.App.Tests.Unit.Services.Foundations
{
    public partial class BookServiceTests
    {
        private readonly Mock<IStorageBroker> _storageBrokerMock;
        private readonly IBookService _bookService;

        public BookServiceTests()
        {
            _storageBrokerMock = new Mock<IStorageBroker>();
            _bookService = new BookService(storageBroker: _storageBrokerMock.Object);
        }
    }
}
