using FactoryMethodSample.FactoryMethod;

namespace FactoryMethodSample.AbstractFactory
{
    internal class Parrot : Bird
    {
        public override IAnimal BirdInterface()
        {
            return new Dog();
        }
    }
}
