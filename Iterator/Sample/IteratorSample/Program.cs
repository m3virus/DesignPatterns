using IteratorSample.Models;

var book = new BookIterator();

book.AddBook(new("first"));
book.AddBook(new("second"));
book.AddBook(new("third"));

foreach (var counter in book)
{
    Console.WriteLine(counter.title);
}