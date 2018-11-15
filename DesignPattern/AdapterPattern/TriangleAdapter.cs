using System;
namespace DesignPattern.AdapterPattern
{
    public class TriangleAdapter:RectInterface
    {
        private Triangle triangle;

        public TriangleAdapter(Triangle t)
        {
            this.triangle = t;
        }

        public void AboutRectangle()
        {
            triangle.AboutTriangle();
        }

        public double CalculateAreaOfRectangle()
        {
            return triangle.CalculateAreaOfTriangle();
        }
    }
}
