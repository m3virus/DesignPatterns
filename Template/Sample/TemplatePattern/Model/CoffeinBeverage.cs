namespace TemplatePattern.Model
{
    internal abstract class CoffeinBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        public abstract void AddCondiments();
        public abstract void Brew();

        public void PourInCup() => Console.WriteLine("PourInCup");
        public void BoilWater() => Console.WriteLine("BoilWater");


    }
}
