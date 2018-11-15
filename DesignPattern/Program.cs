using System;
using DesignPattern.AbstractFactoryPattern;
using DesignPattern.AdapterPattern;
using DesignPattern.BuilderPattern;
using DesignPattern.DecoratorPattern;
using DesignPattern.FactoryMethodPattern;
using DesignPattern.FlyweightPattern;
using DesignPattern.PrototypePattern;
using DesignPattern.ProxyPattern;
using DesignPattern.SimpleFactoryPattern;

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
            //Console.WriteLine("***Builder Pattern Demo***\n");
            //Director director = new Director();
            //IBuilder b1 = new Car("Ford");

            //director.Construct(b1);
            //Product p1 = b1.GetVehicle();
            //p1.Show();
            #endregion

            #region FactoryMethodPattern
            Console.WriteLine("***Factory Pattern Demo***\n");

            //Creating a Tiger Factory
            DesignPattern.FactoryMethodPattern.IAnimalFactory tigerFactory = new TigerFactory();
            //Createing a tiger using the factory method
            IAnimal aTiger = tigerFactory.MakeAnimal();
            //aTiger.Speak();
            //aTiger.Action();

            FactoryMethodPattern.IAnimalFactory dogFactory = new DogFactory();
            IAnimal aDog = dogFactory.CreateAnimal();
            aDog.Speak();
            aDog.Action();
            #endregion

            #region Simple Factory
            //Console.WriteLine("*** Simple Factory Pattern Demo***\n");
            //IAnimal preferredType = null;
            //ISimpleFactory simpleFactory = new SimpleFactory();
            //preferredType = simpleFactory.CreateAnimal();
            //preferredType.Speak();
            //preferredType.Action();
            #endregion

            #region AbstractFactory Pattern
            Console.WriteLine("***Abstract Factory Pattern Demo***");
            DesignPattern.AbstractFactoryPattern.IAnimalFactory wildAnimalFactory = new WildAnimalFactory();
            IDog wildDog = wildAnimalFactory.GetDog();
            wildDog.Speak();
            wildDog.Action();
            ITiger wildTiger = wildAnimalFactory.GetTiger();
            wildTiger.Speak();
            wildTiger.Action();
            Console.WriteLine("below is create pet animal ");
            AbstractFactoryPattern.IAnimalFactory petAnimalFactory = new PetAnimalFactory();
            IDog petDog = petAnimalFactory.GetDog();
            petDog.Speak();
            petDog.Action();
            ITiger petTiger = petAnimalFactory.GetTiger();
            petTiger.Speak();
            petTiger.Action();
            #endregion

            #region Proxy Pattern
            Console.WriteLine("***Proxy Pattern Demo***\n");
            Proxy px = new Proxy();
            px.DoSomeWork();

            ICar car = new ProxyCar(new Driver(15));
            car.DriveCar();
            car = new ProxyCar(new Driver(25));
            car.DriveCar();
            #endregion

            Console.WriteLine("***Decorator pattern Demo...\n");
            ConcreteComponent cc = new ConcreteComponent();


            ConcreteDecoratorEx1 decoratorEx1 = new ConcreteDecoratorEx1(cc);
            //  decoratorEx1.SetTheComponent(cc);
            decoratorEx1.MakeHouse();

            #region Adapter Pattern
            CalculatorAdapter cal = new CalculatorAdapter();
            Triangle t = new Triangle(20, 10);
            Console.WriteLine($"Area of Triangle is:{cal.GetArea(t)} Square unit");


            Rect r = new Rect(20, 10);
            Console.WriteLine($"Area of Rectangle is :{r.CalculateAreaOfRectangle()}");
            Triangle t0 = new Triangle(20, 10);
            Console.WriteLine($"Area of Triangle is :{t0.CalculateAreaOfTriangle()} Square unit.");
            RectInterface adapter = new TriangleAdapter(t0);
            Console.WriteLine($"Area of Triangle using the triangle adapter is :{adapter.CalculateAreaOfRectangle()} square unit");
            #endregion

            Console.WriteLine("***Flyweight Pattern Demo***");
            RobotFactory factory = new RobotFactory();
            IRobot shape = factory.GetRobotFromFactory("Small");
            shape.Print();
            for (int i = 0; i < 2; i++)
            {
                shape = factory.GetRobotFromFactory("Small");
                shape.Print();
            }
            int NumOfDistinctRobots = factory.TotalObjectsCreated;
            Console.WriteLine($"Now,there has {NumOfDistinctRobots} Robots.");
            Console.Read();
        }
    }
}
