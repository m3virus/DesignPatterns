using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes
{
    internal class Cat:IAnimal
    {
        public void Sound() => Console.WriteLine("Cat voice");

    }
}
