using System.Reflection.Metadata.Ecma335;
using Builder.Class;

namespace Builder.Builder
{
    internal class ComputerBuilder
    {
        private Computer computer = new Computer();

        public ComputerBuilder SetCPU(int cpu)
        {
            computer.CPU = cpu;
            return this;
        }
        public ComputerBuilder SetGPU(int gpu)
        {
            computer.GPU = gpu;
            return this;
        }
        public ComputerBuilder SetSSD(int ssd)
        {
            computer.SSD = ssd;
            return this;
        }
        public ComputerBuilder SetRAM(int ram)
        {
            computer.RAM = ram;
            return this;
        }

        public Computer Builder() => computer;

    }
}
