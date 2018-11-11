using System;
namespace DesignPattern.AbstractFactoryPattern
{
    public class PetTiger:ITiger
    {

        public void Action()
        {
            Console.WriteLine("Pet Tigers play in animal circus.\n");
        }

        public void Speak()
        {
            Console.WriteLine("Pet Tiger says:Halum.");
        }
    }
}
