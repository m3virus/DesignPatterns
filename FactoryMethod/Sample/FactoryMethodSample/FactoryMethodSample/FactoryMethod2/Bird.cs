using FactoryMethodSample.FactoryMethod;

namespace FactoryMethodSample.FactoryMethod2
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
