using System;
using DesignPattern.BuilderPattern;
using DesignPattern.FactoryMethodPattern;
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

            #region Prototype
            //Console.WriteLine("***Prototype Pattern Demo***\n");
            //BasicCar nano_base = new Nano("Green Nano") { Price = 100000 };
            //BasicCar ford_base = new Ford("Ford Yellow") { Price = 500000 };

            //BasicCar bc1;
            ////Nano
            //bc1 = nano_base.Clone();
            //bc1.Price = nano_base.Price + BasicCar.SetPrice();
            //Console.WriteLine($"Car is:{bc1.ModelName},and it's price is Rs.{bc1.Price}");
            ////Ford
            //bc1 = ford_base.Clone();
            //bc1.Price = ford_base.Price + BasicCar.SetPrice();
            //Console.WriteLine($"Car is:{bc1.ModelName},and it's price is Rs.{bc1.Price}");
            #endregion

            #region BuiderPattern
            Console.WriteLine("***Builder Pattern Demo***\n");
            Director director = new Director();
            IBuilder b1 = new Car("Ford");

            director.Construct(b1);
            Product p1 = b1.GetVehicle();
            p1.Show();
            #endregion

            #region FactoryMethodPattern
            Console.WriteLine("***Factory Pattern Demo***\n");

            //Creating a Tiger Factory
            IAnimalFactory tigerFactory = new TigerFactory();
            //Createing a tiger using the factory method
            IAnimal aTiger = tigerFactory.CreateAnimal();
            aTiger.Speak();
            aTiger.Action();

            IAnimalFactory dogFactory = new DogFactory();
            IAnimal aDog = dogFactory.CreateAnimal();
            aDog.Speak();
            aDog.Action();
            #endregion

            Console.Read();
        }
    }
}
