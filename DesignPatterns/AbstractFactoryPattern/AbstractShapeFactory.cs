using DesignPatterns.AbstractFactoryPattern;
using DesignPatterns.Interfaces;
using DesignPatters.FactoryPattern;

namespace DesignPatterns.FactoryPattern
{
    public class AbstractShapeFactory : AbstractFactory
    {
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
        //Override
        public override IColor GetColor(string color)
        {
            return null;
        }

        public override IShape GetShape(string shapeType)
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
