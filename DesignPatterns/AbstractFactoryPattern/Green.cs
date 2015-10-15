using DesignPatterns.Interfaces;
using System;

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
