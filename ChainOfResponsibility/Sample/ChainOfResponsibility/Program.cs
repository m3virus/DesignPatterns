using ChainOfResponsibility.Models;

var console = new ConsoleLogger();
var file = new FileLogger();
var email = new EmailLogger();

console.SetNext(file);
file.SetNext(email);

console.Log("Low level log", 1);
console.Log("Medium level log", 2);
console.Log("Critical log", 3);