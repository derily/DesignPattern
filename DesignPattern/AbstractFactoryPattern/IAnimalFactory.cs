using System;
namespace DesignPattern.AbstractFactoryPattern
{
    public interface IAnimalFactory
    {
        IDog GetDog();
        ITiger GetTiger();
    }
    
}
