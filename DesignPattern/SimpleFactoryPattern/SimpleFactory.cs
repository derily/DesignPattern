﻿using System;
using DesignPattern.FactoryMethodPattern;

namespace DesignPattern.SimpleFactoryPattern
{
    public class SimpleFactory : ISimpleFactory
    {
        public override IAnimal CreateAnimal()
        {
            IAnimal intendedAnimal = null;
            Console.WriteLine("Enter your choice(0 for Dog,1 for Tiger)");
            string b1 = Console.ReadLine();
            int input;
            if (int.TryParse(b1, out input))
            {
                Console.WriteLine($"You have entered {input}");
                switch (input)
                {
                    case 0:
                        intendedAnimal = new Dog();
                        break;
                    case 1:
                        intendedAnimal = new Tiger();
                        break;
                    default:
                        Console.WriteLine("You must enter 1 or 0");
                        throw new ApplicationException("Unknown Animal canot be instantiated");
                }
            }
            return intendedAnimal;
        }
    }
}
