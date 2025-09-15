using FactoryMethodSample.FactoryMethod;

namespace FactoryMethodSample.AbstractFactory
{
    internal class Eagle : Bird
    {
        public override IAnimal BirdInterface()
        {
            return new Cat();
        }
    }
}
