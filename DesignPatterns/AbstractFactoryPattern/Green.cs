using DesignPatterns.Interfaces;
using System;
using System.Diagnostics;

namespace DesignPatterns.AbstractFactoryPattern
{
    class Green : IColor
    {
        public IColor IColor
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        //Override
        public void Fill()
        {
            Trace.WriteLine("Inside Green:: Fill() method." + Environment.NewLine);
        }
    }
}
