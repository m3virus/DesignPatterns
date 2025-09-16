using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes
{
    internal class Parrot:IBird
    {
        public void Sound() => Console.WriteLine("Parrot voice");
    }
}
