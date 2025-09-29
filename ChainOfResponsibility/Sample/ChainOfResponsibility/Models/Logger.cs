namespace ChainOfResponsibility.Models
{
    internal abstract class Logger
    {
        protected Logger next;

        public void SetNext(Logger next) => this.next = next;

        public abstract void Log(string message, int level);
    }
}
