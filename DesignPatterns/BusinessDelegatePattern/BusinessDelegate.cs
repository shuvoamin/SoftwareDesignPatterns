using DesignPatterns.Interfaces;

namespace DesignPatterns.BusinessDelegatePattern
{
    public class BusinessDelegate
    {
        private BusinessLookup _lookupService = new BusinessLookup();
        private IBusinessService _businessService;
        private string _serviceType;

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

        public BusinessLookup BusinessLookup
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void SetServiceType(string serviceType)
        {
            _serviceType = serviceType;
        }

        public void DoTask()
        {
            _businessService = _lookupService.GetBusinessService(_serviceType);
            _businessService.DoProcessing();
        }
    }
}
