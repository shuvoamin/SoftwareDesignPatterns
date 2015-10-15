using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.BusinessDelegatePattern
{
    public class JMSService : IBusinessService
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
            Console.WriteLine("Processing task by invoking JMS Service" + Environment.NewLine);
        }
    }
}
