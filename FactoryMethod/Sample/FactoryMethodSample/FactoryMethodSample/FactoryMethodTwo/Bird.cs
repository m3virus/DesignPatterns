using FactoryMethodSample.FactoryMethodOne;

namespace FactoryMethodSample.FactoryMethodTwo
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
