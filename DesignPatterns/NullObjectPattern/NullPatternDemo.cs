using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.NullObjectPattern
{
    public class NullPatternDemo
    {
        public CustomerFactory CustomerFactory
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public static void Output()
        {
            AbstractCustomer customer1 = CustomerFactory.GetCustomer("Rob");
            AbstractCustomer customer2 = CustomerFactory.GetCustomer("Bob");
            AbstractCustomer customer3 = CustomerFactory.GetCustomer("Julie");
            AbstractCustomer customer4 = CustomerFactory.GetCustomer("Laura");

            Console.WriteLine("Customers" + Environment.NewLine);
            Console.WriteLine(customer1.GetName() + Environment.NewLine);
            Console.WriteLine(customer2.GetName() + Environment.NewLine);
            Console.WriteLine(customer3.GetName() + Environment.NewLine);
            Console.WriteLine(customer4.GetName() + Environment.NewLine);
        }
    }
}
