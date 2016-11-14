using System;
using System.Diagnostics;

namespace DesignPatterns.CompositePattern
{
    public class CompositePatternDemo
    {
        public Employee Employee
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
            var CEO = new Employee("John", "CEO", 30000);

            var headSales = new Employee("Robert", "Head Sales", 20000);

            var headMarketing = new Employee("Michel", "Head Marketing", 20000);

            var clerk1 = new Employee("Laura", "Marketing", 10000);
            var clerk2 = new Employee("Bob", "Marketing", 10000);

            var salesExecutive1 = new Employee("Richard", "Sales", 10000);
            var salesExecutive2 = new Employee("Rob", "Sales", 10000);

            CEO.Add(headSales);
            CEO.Add(headMarketing);

            headSales.Add(salesExecutive1);
            headSales.Add(salesExecutive2);

            headMarketing.Add(clerk1);
            headMarketing.Add(clerk2);

            //print all employee of the organisation
            Trace.WriteLine(CEO + Environment.NewLine);

            foreach (var headEmployee in CEO.GetAllEmployee())
            {
                Trace.WriteLine(headEmployee + Environment.NewLine);

                foreach (var employee in headEmployee.GetAllEmployee())
                {
                    Trace.WriteLine(employee + Environment.NewLine);
                }
            }
        }
    }
}
