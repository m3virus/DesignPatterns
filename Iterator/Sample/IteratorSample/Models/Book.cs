namespace IteratorSample.Models
{
    public class Book
    {
        public string title { get; private set; }

        public Book(string title)
        {
            this.title = title;
        }
    }
}
