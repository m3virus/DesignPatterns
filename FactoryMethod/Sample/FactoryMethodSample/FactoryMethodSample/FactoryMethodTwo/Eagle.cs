using FactoryMethodSample.FactoryMethodOne;

namespace FactoryMethodSample.FactoryMethodTwo
{
    internal class Eagle:Bird
    {
        public override IAnimal BirdInterface()
        {
            return new Cat();
        }
    }
}
