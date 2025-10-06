namespace Observer.Model
{
    internal class Subscriber:ISubscriber
    {
        private string name { get; set; }

        public Subscriber(string name)
        {
            this.name = name;
        }


        public void Update(string news)
        {
            Console.WriteLine($"{name} has some news:{news}");
        }
    }
}
