using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ServiceLocatorPattern
{
    public class InitialContext
    {
        public Service2 Service2
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Service1 Service1
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public Object Lookup(string jndiName)
        {
            if (jndiName.Equals("SERVICE1"))
            {
                Console.WriteLine("Looking up and creating a new Service1 object" + Environment.NewLine);
                return new Service1();
            }
            else if (jndiName.Equals("SERVICE2"))
            {
                Console.WriteLine("Looking up and creating a new Service2 object" + Environment.NewLine);
                return new Service2();
            }

            return null;
        }
    }
}
