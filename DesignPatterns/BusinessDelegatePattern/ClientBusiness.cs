using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BusinessDelegatePattern
{
    public class ClientBusiness
    {
        BusinessDelegate _businessService;

        public ClientBusiness(BusinessDelegate businessService)
        {
            _businessService = businessService;
        }

        public BusinessDelegate BusinessDelegate
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void DoTask()
        {
            _businessService.DoTask();
        }
    }
}
