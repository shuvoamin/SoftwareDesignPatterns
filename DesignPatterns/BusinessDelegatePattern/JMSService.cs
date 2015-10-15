using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.BusinessDelegatePattern
{
    public class JMSService : IBusinessService
    {
        public IBusinessService IBusinessService
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }
        //Override
        public void DoProcessing()
        {
            Console.WriteLine("Processing task by invoking JMS Service" + Environment.NewLine);
        }
    }
}
