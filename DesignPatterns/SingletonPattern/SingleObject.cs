using System;

namespace DesignPatterns.SingletonPattern
{
    public class SingleObject
    {
        //create an object of SingleObject
        private static SingleObject instance = new SingleObject();

        //make the constructor private so that this class cannot be
        //instantiated
        private SingleObject() { }

        //Get the only object available
        public static SingleObject getInstance()
        {
            return instance;
        }

        public void showMessage()
        {
            Console.WriteLine("Hello World From Singleton Pattern!" + Environment.NewLine);
        }
    }
}
