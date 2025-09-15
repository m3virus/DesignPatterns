using FactoryMethodSample.FactoryMethod;
using FactoryMethodSample.FactoryMethod2;

Cat a = new Cat();
a.Sound();

Dog b = new Dog();
b.Sound();

Bird c = new Parrot();
c.BirdSound();

Eagle d = new Eagle();
d.BirdSound();
