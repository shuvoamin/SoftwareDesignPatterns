using DesignPatterns.Interfaces;

namespace DesignPatterns.FactoryPattern
{
    public class FactoryPatternDemo
    {
        public ShapeFactory ShapeFactory
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }
    
        public static void Output()
        {
            ShapeFactory shapes = new ShapeFactory();

            //get an object of Circle and call its Draw method
            IShape shape1 = shapes.GetShape("CIRCLE");

            //call Draw method of Circle
            shape1.Draw();

            //get an object of Rectangle and call its Draw method
            IShape shape2 = shapes.GetShape("RECTANGLE");

            //call Draw method of Rectangle
            shape2.Draw();

            //get an object of Square and call its Draw method
            IShape shape3 = shapes.GetShape("SQUARE");

            //call Draw method of Square
            shape3.Draw();
        }
    }
}
