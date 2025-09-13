using FactoryMethodSample.FactoryMethodOne;
using FactoryMethodSample.FactoryMethodTwo;

Cat a = new Cat();
a.Sound();

Dog b = new Dog();
b.Sound();

Bird c = new Parrot();
c.BirdSound();

Eagle d = new Eagle();
d.BirdSound();
