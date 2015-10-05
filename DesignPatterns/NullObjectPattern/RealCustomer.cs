using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.NullObjectPattern
{
    public class RealCustomer : AbstractCustomer
    {
        public RealCustomer(string name)
        {
            _name = name;
        }

        //Override
        public override bool IsNill()
        {
            return false;
        }

        //Override
        public override string GetName()
        {
            return _name;
        }
    }
}
