using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.ServiceLocatorPattern
{
    public class CacheServiceLocator
    {
        private readonly List<IService> _services;

        public CacheServiceLocator()
        {
            _services = new List<IService>();
        }

        public IService GetService(string serviceName)
        {
            foreach (var service in _services.Where(service => service.GetName().Equals(serviceName)))
            {
                Console.WriteLine("Returning cached  " + serviceName + " object");
                return service;
            }
            return null;
        }

        public void AddService(IService newService)
        {
            var exists = false;

            foreach (var service in _services.Where(service => service.GetName().Equals(newService.GetName())))
            {
                exists = true;
            }

            if (!exists)
            {
                _services.Add(newService);
            }
        }
    }
}
