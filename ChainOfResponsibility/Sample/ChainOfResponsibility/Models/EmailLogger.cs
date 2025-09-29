namespace ChainOfResponsibility.Models
{
    internal class EmailLogger:Logger
    {
        public override void Log(string message, int level)
        {
            
                Console.WriteLine($"Email log:{message}");
            
        }
    }
}
