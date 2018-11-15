using System;
namespace DesignPattern.AdapterPattern
{
    public class Rect:RectInterface
    {
        public double length;
        public double width;

        public Rect(double l,double w)
        {
            this.length = l;
            this.width = w;
        }

        public void AboutRectangle()
        {
            Console.WriteLine("Actually,I am a Rectangle");
        }

        public double CalculateAreaOfRectangle()
        {
            return length * width;
        }
    }
}
