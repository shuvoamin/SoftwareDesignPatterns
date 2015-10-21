namespace DesignPatterns.BusinessDelegatePattern
{
    public class ClientBusiness
    {
        readonly BusinessDelegate _businessService;

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
        }

        public void DoTask()
        {
            _businessService.DoTask();
        }
    }
}
