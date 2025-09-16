using AbstractFactory.Factories;
using AbstractFactory.Interfaces;

IJungle a = new HuntFactory();

a.AnimalCreate().Sound();
a.BirdCreate().Sound();

IJungle b = new HunterFactory();

b.AnimalCreate().Sound();
b.BirdCreate().Sound();
