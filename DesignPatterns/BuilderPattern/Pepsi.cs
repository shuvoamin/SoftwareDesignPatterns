using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public class Pepsi : ColdDrink
    {
        //Override
        public override string name()
        {
            return "Pepsi";
        }

        //Overide
        public override float price()
        {
            return 30.0F;
        }
    }
}
