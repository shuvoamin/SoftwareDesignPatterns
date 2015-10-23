using System;

namespace DesignPatterns.NullObjectPattern
{
    public class NullPatternDemo
    {
        public CustomerFactory CustomerFactory
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }
    
        public static void Output()
        {
            var customer1 = CustomerFactory.GetCustomer("Rob");
            var customer2 = CustomerFactory.GetCustomer("Bob");
            var customer3 = CustomerFactory.GetCustomer("Julie");
            var customer4 = CustomerFactory.GetCustomer("Laura");

            Console.WriteLine("Customers" + Environment.NewLine);
            Console.WriteLine(customer1.GetName() + Environment.NewLine);
            Console.WriteLine(customer2.GetName() + Environment.NewLine);
            Console.WriteLine(customer3.GetName() + Environment.NewLine);
            Console.WriteLine(customer4.GetName() + Environment.NewLine);
        }
    }
}
