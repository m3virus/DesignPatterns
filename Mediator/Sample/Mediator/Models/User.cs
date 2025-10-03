using System.Xml.Linq;

namespace Mediator.Models
{
    internal class User
    {
        private IChatMediator _mediator;

        public User(string userName, IChatMediator mediator)
        {
            _mediator = mediator;
            UserName = userName;
        }

        public string UserName { get; }

        public void Send(string message)
        {
            Console.WriteLine($"{UserName} sends: {message}");
            _mediator.SendMessage(message, this);
        }

        public void Receive(string message)
        {
            Console.WriteLine($"{UserName} received: {message}");
        }
    }
}
