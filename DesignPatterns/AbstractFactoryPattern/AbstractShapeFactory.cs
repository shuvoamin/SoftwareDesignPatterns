using DesignPatterns.FactoryPattern;
using DesignPatterns.Interfaces;
using DesignPatters.FactoryPattern;

namespace DesignPatterns.AbstractFactoryPattern
{
    public class AbstractShapeFactory : AbstractFactory
    {
        public Circle Circle
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public Rectangle Rectangle
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public Square Square
        {
            get
            {
                throw new System.NotImplementedException();
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
