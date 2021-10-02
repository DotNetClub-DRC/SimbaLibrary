using FluentAssertions;
using Force.DeepCloner;
using Moq;
using SimbaLibrary.App.Models.Books;
using Xunit;

namespace SimbaLibrary.App.Tests.Unit.Services.Foundations
{
    public partial class BookServiceTests
    {
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
