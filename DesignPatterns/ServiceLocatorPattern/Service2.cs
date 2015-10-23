using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.ServiceLocatorPattern
{
    public class Service2 : IService
    {
        public IService Service
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        //Override
        public string GetName()
        {
            return "Service 2";
        }

        //Override
        public void Execute()
        {
            Console.WriteLine("Executing Service 2" + Environment.NewLine);
        }
    }
}
