using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.ServiceLocatorPattern
{
    public class ServiceLocator
    {
        private static readonly CacheServiceLocator Cache;

        static ServiceLocator() 
        {
           Cache = new CacheServiceLocator();		
        }

        public InitialContext InitialContext
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public CacheServiceLocator CacheServiceLocator
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public static IService GetService(string jndiName)
        {

            var service = Cache.GetService(jndiName);

            if (service != null)
            {
                return service;
            }

            var context = new InitialContext();
            var service1 = (IService)context.Lookup(jndiName);
            Cache.AddService(service1);
            return service1;
        }
    }
}
