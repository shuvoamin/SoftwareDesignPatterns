using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.BusinessDelegatePattern
{
    public class EJBService : IBusinessService
    {
        public DesignPatterns.Interfaces.IBusinessService IBusinessService
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
        public void DoProcessing()
        {
            Console.WriteLine("Processing task by invoking EJB Service" + Environment.NewLine);
        }
    }
}
