using System;
namespace DesignPattern.DecoratorPattern
{
    public class ConcreteComponent:Component
    {

        public override void MakeHouse()
        {
            Console.WriteLine("Original House is complete.it is closed for modification.");
        }
    }
}
