using DesignPatterns.Interfaces;
using DesignPatters.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    public class ShapeFactory
    {
        public DesignPatters.FactoryPattern.Rectangle Rectangle
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Circle Circle
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Square Square
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public IShape GetShape(string shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            if (shapeType.Equals("CIRCLE"))
            {
                return new Circle();
            }
            if (shapeType.Equals("RECTANGLE"))
            {
                return new Rectangle();
            }
            if (shapeType.Equals("SQUARE"))
            {
                return new Square();
            }
            return null;
        }
    }
}
