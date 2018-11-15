using System;
namespace DesignPattern.AdapterPattern
{
    public class Calculator
    {
        public double GetArea(Rect rect){
            return rect.length * rect.width;
        }
    }
}
