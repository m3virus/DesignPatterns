using Prototype.Class;

var x = new Axe
{
    Name = "alii",
    Power = 100,
    Ulti = "Culling blade"
};

var a = x.ClonEntity();

Console.WriteLine(x.ToString());
Console.WriteLine(a.ToString());

