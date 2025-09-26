namespace DecoratorSample.Model
{
    internal class EmailNotifier:INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email send: {message}");
        } 
    }
}
