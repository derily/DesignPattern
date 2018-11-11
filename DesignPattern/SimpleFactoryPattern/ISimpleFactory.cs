using System;
using DesignPattern.FactoryMethodPattern;

namespace DesignPattern.SimpleFactoryPattern
{
    public abstract class ISimpleFactory
    {
        public abstract IAnimal CreateAnimal();
    }
}
