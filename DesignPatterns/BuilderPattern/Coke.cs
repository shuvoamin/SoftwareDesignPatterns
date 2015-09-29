using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public class Coke : ColdDrink
    {
        //Override
        public override string name()
        {
            return "Coke";
        }

        //Overide
        public override float price()
        {
            return 35.0F;
        }
    }
}
