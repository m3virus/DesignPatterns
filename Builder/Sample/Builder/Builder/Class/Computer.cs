using Builder.Builder;

namespace Builder.Class
{
    internal class Computer
    {
        public int CPU { get; set; }
        public int GPU { get; set; }
        public int RAM { get; set; }
        public int SSD { get; set; }

        public void ComputerDesign()
        {
            Console.WriteLine($"CPU: {CPU}" +
                              $"GPU: {GPU}" +
                              $"RAM: {RAM}" +
                              $"SSD: {SSD}");
        }
        
    }
}
