using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes
{
    internal class Eagle: IBird
    {
        public void Sound() => Console.WriteLine("Eagle voice");
    }
}
