using SimbaLibrary.App.Brokers.Storages;
using SimbaLibrary.App.Models.Books;
using SimbaLibrary.App.Services.Foundations.Books;

var storageBroker = new StorageBroker();
var bookService = new BookService(storageBroker);
var book = new Book();

bookService.AddBook(null);
