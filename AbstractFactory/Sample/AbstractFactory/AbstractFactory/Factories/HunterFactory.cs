using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Classes;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    internal class HunterFactory:IJungle
    {
        public IAnimal AnimalCreate()
        {
            return new Dog();
        }

        public IBird BirdCreate()
        {
            return new Eagle();
        }
    }
}
