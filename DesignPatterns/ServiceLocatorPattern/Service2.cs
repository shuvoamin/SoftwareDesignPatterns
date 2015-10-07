using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ServiceLocatorPattern
{
    public class Service2 : IService
    {
        public DesignPatterns.Interfaces.IService IService
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
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
