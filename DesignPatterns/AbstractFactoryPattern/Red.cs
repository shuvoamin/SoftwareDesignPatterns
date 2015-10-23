using DesignPatterns.Interfaces;
using System;
using System.Diagnostics;

namespace DesignPatterns.AbstractFactoryPattern
{
    public class Red : IColor
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
            Trace.WriteLine("Inside Red:: Fill() method." + Environment.NewLine);
        }
    }
}
