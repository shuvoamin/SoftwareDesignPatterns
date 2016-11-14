using System.Linq;

namespace DesignPatterns.NullObjectPattern
{
    public class CustomerFactory
    {
        public static readonly string[] Names = {"Rob", "Joe", "Julie"};

        public NullCustomer NullCustomer
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public RealCustomer RealCustomer
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public static AbstractCustomer GetCustomer(string name)
        {
            if (Names.Any(t => t.Equals(name)))
            {
                return new RealCustomer(name);
            }

            return new NullCustomer();
        }
    }
}
