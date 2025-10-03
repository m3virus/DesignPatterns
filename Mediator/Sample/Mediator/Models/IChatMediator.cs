namespace Mediator.Models
{
    internal interface IChatMediator
    {
        void AddUser(User user);
        void SendMessage(string message, User user);
    }
}
