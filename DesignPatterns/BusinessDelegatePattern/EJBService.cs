using DesignPatterns.Interfaces;
using System;
using System.Diagnostics;

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
            Trace.WriteLine("Processing task by invoking EJB Service" + Environment.NewLine);
        }
    }
}
