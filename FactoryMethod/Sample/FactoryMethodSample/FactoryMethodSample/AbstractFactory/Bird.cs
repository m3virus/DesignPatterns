using FactoryMethodSample.FactoryMethod;

namespace FactoryMethodSample.AbstractFactory
{
    internal abstract class Bird
    {
        public abstract IAnimal BirdInterface();

        public void BirdSound()
        {
            var bird = BirdInterface();
            bird.Sound();
        }
    }
}
