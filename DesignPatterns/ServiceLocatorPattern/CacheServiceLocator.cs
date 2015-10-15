using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;

namespace DesignPatterns.ServiceLocatorPattern
{
    public class CacheServiceLocator
    {
        private List<IService> _services;

        public CacheServiceLocator()
        {
            _services = new List<IService>();
        }

        public IService GetService(String serviceName)
        {

            foreach (IService service in _services)
            {
                if (service.GetName().Equals(serviceName))
                {
                    Console.WriteLine("Returning cached  " + serviceName + " object");
                    return service;
                }
            }
            return null;
        }

        public void AddService(IService newService)
        {
            Boolean exists = false;

            foreach (IService service in _services)
            {
                if (service.GetName().Equals(newService.GetName()))
                {
                    exists = true;
                }
            }

            if (!exists)
            {
                _services.Add(newService);
            }
        }
    }
}
