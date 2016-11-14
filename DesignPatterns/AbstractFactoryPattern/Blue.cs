using DesignPatterns.Interfaces;
using System;
using System.Diagnostics;

namespace DesignPatterns.AbstractFactoryPattern
{
    class Blue : IColor
    {
        public IColor Color
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        //Override
        public void Fill()
        {
            Trace.WriteLine("Inside Blue:: Fill() method." + Environment.NewLine);
        }
    }
}
