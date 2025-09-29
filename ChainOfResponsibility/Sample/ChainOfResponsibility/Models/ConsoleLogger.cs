namespace ChainOfResponsibility.Models
{
    internal class ConsoleLogger:Logger
    {
        public override void Log(string message, int level)
        {
            if (level <= 1)
            {
                Console.WriteLine($"Console log:{message}");
            }
            else
            {
                next?.Log(message, level);
            }
        }
    }
}
