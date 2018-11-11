using System;
namespace DesignPattern.ProxyPattern
{
    public class Proxy:Subject
    {
        Subject cs;

        public override void DoSomeWork()
        {
            Console.WriteLine("Proxy call happening now...");

            //checking preconditions before operations on the real object are invoked. 
            if (cs==null){
                cs = new ConcreteSubject();
            }
            cs.DoSomeWork();
        }
    }
}
