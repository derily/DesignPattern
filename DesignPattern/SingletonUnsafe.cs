using System;
namespace DesignPattern
{
    public class SingletonUnsafe
    {
        private static SingletonUnsafe instance;
        private SingletonUnsafe() { }

        public static SingletonUnsafe Instance
        {
            get
            {
                // this line is not thread safe
                // in a multithreaded environment,suppose two threads try to evaluate this
                // if they see that the instance has not been created,each of then will try to create a new instance,
                // as a result,you may end up with multiple instances of the class.
                if (instance == null)
                {
                    instance = new SingletonUnsafe();
                }
                return instance;
            }
        }

    }
}
