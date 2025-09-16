namespace AbstractFactory.Interfaces
{
    internal interface IJungle
    {
        public abstract IAnimal AnimalCreate();
        public abstract IBird BirdCreate();
    }
}
