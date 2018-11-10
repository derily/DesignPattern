using System;
namespace DesignPattern.FactoryMethodPattern
{
    public class TigerFactory:IAnimalFactory
    {
        public TigerFactory()
        {
        }

        public override IAnimal CreateAnimal()
        {
            return new Tiger();
        }
    }
}
