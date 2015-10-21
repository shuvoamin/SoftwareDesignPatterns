using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.BusinessDelegatePattern
{
    public class EjbService : IBusinessService
    {
        public IBusinessService BusinessService
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        //Override
        public void DoProcessing()
        {
            Console.WriteLine("Processing task by invoking EJB Service" + Environment.NewLine);
        }
    }
}
