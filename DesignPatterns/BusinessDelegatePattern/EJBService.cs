using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
