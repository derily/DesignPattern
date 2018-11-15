using System;
namespace DesignPattern.FlyweightPattern
{
    public class LargeRobot:IRobot
    {
        public void Print()
        {
            Console.WriteLine("I am a large Robot");
        }
    }
}
