using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public class Bottle : IPacking
    {
        public DesignPatterns.Interfaces.IPacking IPacking
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
        //Override
        public string pack()
        {
            return "Bottle";
        }
    }
}
