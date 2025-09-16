using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes
{
    internal class Dog : IAnimal
    {
        public void Sound() => Console.WriteLine("dog voice");
    }
}
