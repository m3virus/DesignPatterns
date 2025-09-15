using FactoryMethodSample.FactoryMethod;
using FactoryMethodSample.FactoryMethod2;

namespace FactoryMethodSample.FactoryMethod2
{
    internal class Parrot : Bird
    {
        public override IAnimal BirdInterface()
        {
            return new Dog();
        }
    }
}
