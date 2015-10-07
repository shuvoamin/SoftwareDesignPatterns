using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ServiceLocatorPattern
{
    public class ServiceLocatorPatternDemo
    {
        public ServiceLocator ServiceLocator
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public static void Output()
        {
            IService service = ServiceLocator.GetService("SERVICE1");
            service.Execute();
            service = ServiceLocator.GetService("SERVICE2");
            service.Execute();
            service = ServiceLocator.GetService("SERVICE1");
            service.Execute();
            service = ServiceLocator.GetService("SERVICE2");
            service.Execute();	
        }
    }
}
