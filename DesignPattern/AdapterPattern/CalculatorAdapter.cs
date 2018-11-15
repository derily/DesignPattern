using System;
namespace DesignPattern.AdapterPattern
{
    public class CalculatorAdapter
    {
        public CalculatorAdapter()
        {
        }

        public double GetArea(Triangle triangle){
            Calculator c = new Calculator();
            Rect rect = new Rect(triangle.baseT,0.5*triangle.height);
            //rect.length = triangle.baseT;
            //rect.width = 0.5 * triangle.height;
            return c.GetArea(rect);
        }
    }
}
