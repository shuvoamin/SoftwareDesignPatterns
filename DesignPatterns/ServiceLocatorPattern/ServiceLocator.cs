using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.ServiceLocatorPattern
{
    public class ServiceLocator
    {
        private static CacheServiceLocator _cache;

        static ServiceLocator() 
        {
           _cache = new CacheServiceLocator();		
        }

        public InitialContext InitialContext
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }

        public CacheServiceLocator CacheServiceLocator
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }

        public static IService GetService(string jndiName)
        {

            var service = _cache.GetService(jndiName);

            if (service != null)
            {
                return service;
            }

            var context = new InitialContext();
            var service1 = (IService)context.Lookup(jndiName);
            _cache.AddService(service1);
            return service1;
        }
    }
}
