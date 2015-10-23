using System;
using System.Diagnostics;

namespace DesignPatterns.ServiceLocatorPattern
{
    public class InitialContext
    {
        public Service2 Service2
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Service1 Service1
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    
        public object Lookup(string jndiName)
        {
            if (jndiName.Equals("SERVICE1"))
            {
                Trace.WriteLine("Looking up and creating a new Service1 object" + Environment.NewLine);
                return new Service1();
            }
            if (jndiName.Equals("SERVICE2"))
            {
                Trace.WriteLine("Looking up and creating a new Service2 object" + Environment.NewLine);
                return new Service2();
            }

            return null;
        }
    }
}
