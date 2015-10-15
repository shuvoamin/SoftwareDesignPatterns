using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.AbstractFactoryPattern
{
    public class ColorFactory : AbstractFactory
    {
        internal Blue Blue
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal Green Green
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Red Red
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
        public override IShape GetShape(String color)
        {
            return null;
        }

        //Override
        public override IColor GetColor(string color)
        {
            if (color == null)
            {
                return null;
            }
            if (color.Equals("RED"))
            {
                return new Red();
            }
            else if (color.Equals("GREEN"))
            {
                return new Green();
            }
            else if (color.Equals("BLUE"))
            {
                return new Blue();
            }
            return null;
        }
    }
}
