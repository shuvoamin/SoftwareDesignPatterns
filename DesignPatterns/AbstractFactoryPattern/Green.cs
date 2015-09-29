using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryPattern
{
    class Green : IColor
    {
        public DesignPatterns.Interfaces.IColor IColor
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
        public void Fill()
        {
            Console.WriteLine("Inside Green:: Fill() method." + Environment.NewLine);
        }
    }
}
