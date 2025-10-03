using System.Reflection;

namespace Mediator.Models
{
    internal class ChatMediator:IChatMediator
    {
        private List<User> users = new List<User>();
        public void AddUser(User user) => users.Add(user);

        public void SendMessage(string message, User user)
        {
            foreach (var counter in users)
            {
                if (counter != user)
                    counter.Receive(message);
            }
        }
    }
}
