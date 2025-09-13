using FactoryMethodSample.FactoryMethodOne;

namespace FactoryMethodSample.FactoryMethodTwo
{
    internal class Parrot:Bird
    {
        public override IAnimal BirdInterface()
        {
            return new Dog();
        }
    }
}
