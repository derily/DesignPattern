using System;
namespace DesignPattern.FactoryMethodPattern
{
    public class DogFactory:IAnimalFactory
    {
        public DogFactory()
        {
        }

        public override IAnimal CreateAnimal()
        {
            return new Dog();
        }
    }
}
