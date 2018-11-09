using System;
using System.Collections.Generic;

namespace DesignPattern.BuilderPattern
{
    public class Product
    {
        private LinkedList<string> parts;
        public Product()
        {
            parts = new LinkedList<string>();
        }
        public void Add(string part){
            parts.AddLast(part);
        }
        public void Show(){
            Console.WriteLine("\nProduct completed as below :");
            foreach (var part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
