using static System.Net.Mime.MediaTypeNames;

namespace ChainOfResponsibility.Models
{
    internal class FileLogger:Logger
    {
        public override void Log(string message, int level)
        {
            if (level <= 2)
            {
                Console.WriteLine($"File log:{message}");
            }
            else
            {
                next?.Log(message, level);
            }
        }
    }
}
