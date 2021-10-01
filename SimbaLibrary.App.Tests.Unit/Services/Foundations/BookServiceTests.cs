using FluentAssertions;
using Force.DeepCloner;
using Moq;
using SimbaLibrary.App.Brokers.Storages;
using SimbaLibrary.App.Models.Books;
using SimbaLibrary.App.Services.Foundations.Books;
using Xunit;

namespace SimbaLibrary.App.Tests.Unit.Services.Foundations
{
    public class BookServiceTests
    {
        private readonly Mock<IStorageBroker> _storageBrokerMock;
        private readonly IBookService _bookService;

        public BookServiceTests()
        {
            _storageBrokerMock = new Mock<IStorageBroker>();
            _bookService = new BookService(storageBroker: _storageBrokerMock.Object);
        }

        [Fact]
        public void ShouldAddBook()
        {
            // given

            var randomBook = new Book();
            Book inputBook = randomBook;
            Book storageBook = inputBook;
            Book expectedBook = storageBook.DeepClone();

            _storageBrokerMock.Setup(broker => 
                broker.InsertBook(inputBook))
                .Returns(expectedBook);

            // when

            Book actualBook = _bookService.AddBook(inputBook);

            // then

            actualBook.Should().BeEquivalentTo(expectedBook);

            _storageBrokerMock.Verify(broker => 
                broker.InsertBook(inputBook),
                Times.Once);

            _storageBrokerMock.VerifyNoOtherCalls();
        }
    }
}
