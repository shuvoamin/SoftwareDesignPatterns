using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.ServiceLocatorPattern
{
    public class Service1 : IService
    {
        public IService IService
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }
        //Override
        public string GetName()
        {
            return "Service 1";
        }

        //Override
        public void Execute()
        {
            Console.WriteLine("Executing Service 1" + Environment.NewLine);
        }
    }
}
