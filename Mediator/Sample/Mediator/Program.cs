using Mediator.Models;

var chatMediator = new ChatMediator();

var user1 = new User("Ali", chatMediator);
var user2 = new User("Sara", chatMediator);
var user3 = new User("Reza", chatMediator);

chatMediator.AddUser(user1);
chatMediator.AddUser(user2);
chatMediator.AddUser(user3);

user1.Send("Hi everybody!");
user2.Send("Hi Ali!");