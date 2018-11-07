using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Singleton Pattern Demo***");
            Console.WriteLine("Trying to create instance s1.");
            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;
            if (s1 == s2)
            {
                Console.WriteLine("Only on instance exists.");

            }
            else
            {
                Console.WriteLine("Different instances exist.");
            }
            Console.Read();
        }
    }
}
