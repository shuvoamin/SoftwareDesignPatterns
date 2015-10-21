using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.BusinessDelegatePattern
{
    public class JmsService : IBusinessService
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
            Console.WriteLine("Processing task by invoking JMS Service" + Environment.NewLine);
        }
    }
}
