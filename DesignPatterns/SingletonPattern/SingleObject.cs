using System;

namespace DesignPatterns.SingletonPattern
{
    public class SingleObject
    {
        //create an object of SingleObject
        private static readonly SingleObject Instance = new SingleObject();

        //make the constructor private so that this class cannot be
        //instantiated
        private SingleObject() { }

        //Get the only object available
        public static SingleObject GetInstance()
        {
            return Instance;
        }

        public void ShowMessage()
        {
            Console.WriteLine("Hello World From Singleton Pattern!" + Environment.NewLine);
        }
    }
}
