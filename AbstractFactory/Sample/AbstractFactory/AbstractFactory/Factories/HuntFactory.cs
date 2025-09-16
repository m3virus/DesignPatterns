using AbstractFactory.Classes;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    internal class HuntFactory:IJungle
    {
        public IAnimal AnimalCreate()
        {
            return new Cat();
        }

        public IBird BirdCreate()
        {
            return new Parrot();
        }
    }
}
