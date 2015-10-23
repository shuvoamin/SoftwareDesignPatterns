using DesignPatterns.Interfaces;
using System;
using System.Diagnostics;

namespace DesignPatterns.AbstractFactoryPattern
{
    public class Red : IColor
    {
        public IColor IColor
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }

        //Override
        public void Fill()
        {
            Trace.WriteLine("Inside Red:: Fill() method." + Environment.NewLine);
        }
    }
}
