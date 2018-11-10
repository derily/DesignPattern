using System;
namespace DesignPattern.FactoryMethodPattern
{
    //this is an abstract class,so you can take the advantage of using 
    //an abstract class.Suppose you want a subclass to follow a rule 
    public abstract class IAnimalFactory
    {
        public IAnimal MakeAnimal(){
            Console.WriteLine("\n IAnimalFactory.MakeAnimal()-You cannot ignore parent rules.");
            IAnimal animal = CreateAnimal();
            animal.Speak();
            animal.Action();
            return animal;
        }
       public abstract IAnimal CreateAnimal();
    }
}
