using System.Collections;

namespace IteratorSample.Models
{
    internal class BookIterator: IEnumerable<Book>
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book) => books.Add(book);
        public IEnumerator<Book> GetEnumerator()
        {
            foreach (var counter in books)
            {
                yield return counter;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
