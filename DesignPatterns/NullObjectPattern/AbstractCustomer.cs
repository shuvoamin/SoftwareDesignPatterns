using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.NullObjectPattern
{
    public abstract class AbstractCustomer
    {
        protected string _name;

        public abstract bool IsNill();
        public abstract string GetName();
    }
}
