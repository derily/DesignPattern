using System;
namespace DesignPattern.FlyweightPattern
{
    public class SmallRobot:IRobot
    {

        public void Print()
        {
            Console.WriteLine("This is a small Robot.");
        }
    }
}
