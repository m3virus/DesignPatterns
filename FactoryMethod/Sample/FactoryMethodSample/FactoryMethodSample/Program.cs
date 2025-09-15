using FactoryMethodSample.AbstractFactory;
using FactoryMethodSample.FactoryMethod;

Cat a = new Cat();
a.Sound();

Dog b = new Dog();
b.Sound();

Bird c = new Parrot();
c.BirdSound();

Eagle d = new Eagle();
d.BirdSound();
