using DesignPatterns.Interfaces;
using System;
using System.Diagnostics;

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
            Trace.WriteLine("Processing task by invoking JMS Service" + Environment.NewLine);
        }
    }
}
