using DesignPatterns.Interfaces;

namespace DesignPatterns.BusinessDelegatePattern
{
    public class BusinessLookup
    {
        public IBusinessService GetBusinessService(string serviceType)
        {
            if (serviceType.Equals("EJB"))
            {
                return new EjbService();
            }
            else
            {
                return new JmsService();
            }
        }
    }
}
