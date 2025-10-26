using Core.Models;

namespace Core.Services
{
    public sealed class LoggingSingleton
    {
        private static readonly Lazy<LoggingSingleton> _instance = new Lazy<LoggingSingleton>(() => new LoggingSingleton());
        public static LoggingSingleton Instance => _instance.Value;

        private LoggingSingleton()
        {
            
        }

        public void Log(string message)
        {
            Console.WriteLine($"[{DateTime.Now}]:{message}");
        }

    }
}
