using System;
namespace DesignPattern.DecoratorPattern
{
    public class ConcreteDecoratorEx1:AbstractDecorator
    {
        public ConcreteDecoratorEx1(Component component)
        {
            base.SetTheComponent(component);
        }
        public override void MakeHouse()
        {
            base.MakeHouse();
            Console.WriteLine("***Using a decorator***");
            AddFloor();
        }
        private void AddFloor(){
            Console.WriteLine("I am making an additional floor on top of it.");
        }
    }
}
