using FluentAssertions;
using Force.DeepCloner;
using Moq;
using SimbaLibrary.App.Models.Books;
using System;
using Xunit;

namespace SimbaLibrary.App.Tests.Unit.Services.Foundations
{
    public partial class BookServiceTests
    {
        [Fact]
        public void ShouldRetrieveBookById()
        {
            // given

            Guid randomId =  Guid.NewGuid();
            Guid inputBookId = randomId;
            Book randomBook = new Book();
            Book storageBook = randomBook;
            Book expectedBook = storageBook;

            _storageBrokerMock.Setup(broker => 
                broker.SelectBookById(inputBookId))
                .Returns(storageBook);

            // when

            Book actualBook = _bookService.RetrieveBookById(inputBookId);

            // then

            actualBook.Should().BeEquivalentTo(expectedBook);

            _storageBrokerMock.Verify(broker => 
                broker.SelectBookById(inputBookId),
                Times.Once);

            _storageBrokerMock.VerifyNoOtherCalls();
        }
    }
}
