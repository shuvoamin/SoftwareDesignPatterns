using System;
using System.Diagnostics;

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
        }
    
        public static void Output()
        {
            var customer1 = CustomerFactory.GetCustomer("Rob");
            var customer2 = CustomerFactory.GetCustomer("Bob");
            var customer3 = CustomerFactory.GetCustomer("Julie");
            var customer4 = CustomerFactory.GetCustomer("Laura");

            Trace.WriteLine("Customers" + Environment.NewLine);
            Trace.WriteLine(customer1.GetName() + Environment.NewLine);
            Trace.WriteLine(customer2.GetName() + Environment.NewLine);
            Trace.WriteLine(customer3.GetName() + Environment.NewLine);
            Trace.WriteLine(customer4.GetName() + Environment.NewLine);
        }
    }
}
