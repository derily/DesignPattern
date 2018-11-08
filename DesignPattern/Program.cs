using System;
using DesignPattern.PrototypePattern;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Singleton
            //Console.WriteLine("***Singleton Pattern Demo***");
            //Console.WriteLine("Trying to create instance s1.");
            //Singleton s1 = Singleton.Instance;
            //Singleton s2 = Singleton.Instance;
            //if (s1 == s2)
            //{
            //    Console.WriteLine("Only on instance exists.");

            //}
            //else
            //{
            //    Console.WriteLine("Different instances exist.");
            //}
            #endregion

            Console.WriteLine("***Prototype Pattern Demo***\n");
            BasicCar nano_base = new Nano("Green Nano") { Price = 100000 };
            BasicCar ford_base = new Ford("Ford Yellow") { Price = 500000 };

            BasicCar bc1;
            //Nano
            bc1 = nano_base.Clone();
            bc1.Price = nano_base.Price + BasicCar.SetPrice();
            Console.WriteLine($"Car is:{bc1.ModelName},and it's price is Rs.{bc1.Price}");
            //Ford
            bc1 = ford_base.Clone();
            bc1.Price = ford_base.Price + BasicCar.SetPrice();
            Console.WriteLine($"Car is:{bc1.ModelName},and it's price is Rs.{bc1.Price}");

            Console.Read();
        }
    }
}
