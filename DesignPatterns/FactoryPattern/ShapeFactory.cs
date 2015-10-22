using DesignPatterns.Interfaces;

namespace DesignPatterns.FactoryPattern
{
    public class ShapeFactory
    {
        public Rectangle Rectangle
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
