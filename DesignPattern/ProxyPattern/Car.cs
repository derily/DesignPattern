using System;
namespace DesignPattern.ProxyPattern
{
    public class Car:ICar
    {
        public void DriveCar()
        {
            Console.WriteLine("Car has been driven!");
        }
    }
}
