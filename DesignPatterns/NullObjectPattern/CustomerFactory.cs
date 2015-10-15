namespace DesignPatterns.NullObjectPattern
{
    public class CustomerFactory
    {
        public static readonly string[] names = {"Rob", "Joe", "Julie"};

        public NullCustomer NullCustomer
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public RealCustomer RealCustomer
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public static AbstractCustomer GetCustomer(string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Equals(name))
                {
                    return new RealCustomer(name);
                }
            }

            return new NullCustomer();
        }
    }
}
