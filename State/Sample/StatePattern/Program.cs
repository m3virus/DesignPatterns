using StatePattern.Models;
using StatePattern.States;

var a = new Player(new Standing());

a.Update();
a.HandleState();

a.Update();
a.HandleState();

a.Update();
a.HandleState();