using DesignPatterns.Interfaces;

namespace DesignPatterns.BusinessDelegatePattern
{
    public class BusinessDelegate
    {
        private readonly BusinessLookup _lookupService = new BusinessLookup();
        private IBusinessService _businessService;
        private string _serviceType;

        public IBusinessService BusinessService
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public BusinessLookup BusinessLookup
        {
            get
            {
                throw new System.NotImplementedException();
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
