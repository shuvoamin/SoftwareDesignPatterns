using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.NullObjectPattern
{
    public class NullCustomer : AbstractCustomer
    {
        //Override
        public override string GetName()
        {
            return "Not Avilable in Customer Database";
        }

        //Overide
        public override bool IsNill()
        {
            return true;
        }
    }
}
