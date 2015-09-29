using DesignPatterns.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryPattern
{
    public class FactoryProducer
    {
        public AbstractFactory AbstractFactory
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public static AbstractFactory GetFactory(string choice)
        {
            if (choice.Equals("SHAPE"))
            {
                return new AbstractShapeFactory();
            }
            else if (choice.Equals("COLOR"))
            {
                return new ColorFactory();
            }
            return null;
        }
    }
}
