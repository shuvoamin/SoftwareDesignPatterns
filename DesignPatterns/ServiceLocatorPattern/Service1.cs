using DesignPatterns.Interfaces;
using System;
using System.Diagnostics;

namespace DesignPatterns.ServiceLocatorPattern
{
    public class Service1 : IService
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
            return "Service 1";
        }

        //Override
        public void Execute()
        {
            Trace.WriteLine("Executing Service 1" + Environment.NewLine);
        }
    }
}
