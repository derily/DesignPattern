using System;
namespace DesignPattern.AdapterPattern
{
    public class Triangle:TriInterface
    {
        public double baseT;
        public double height;
        public Triangle(int b,int h){
            this.baseT = b;
            this.height = h;
        }

        public void AboutTriangle()
        {
            Console.WriteLine("Actually,I am a Triangle.");
        }

        public double CalculateAreaOfTriangle()
        {
            return 0.5 * baseT * height;
        }
    }
}
