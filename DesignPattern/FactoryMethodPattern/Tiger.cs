using System;
namespace DesignPattern.FactoryMethodPattern
{
    public class Tiger:IAnimal
    {
        public Tiger()
        {
        }

        public void Action()
        {
            Console.WriteLine("Tiger says:Halum.");

        }

        public void Speak()
        {
            Console.WriteLine("Tigers prefer hunting...\n");
        }
    }
}
