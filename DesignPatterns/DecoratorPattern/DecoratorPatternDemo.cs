using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.DecoratorPattern
{
    public class DecoratorPatternDemo
    {
        public ShapeDecorator ShapeDecorator
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }
    
        public static void Output()
        {
            IShape circle = new CircleDecorator();

            IShape redCircle = new RedShapeDecorator(new CircleDecorator());

            IShape redRectangle = new RedShapeDecorator(new RectangleDecorator());
            Console.WriteLine("Circle with normal border");
            circle.Draw();

            Console.WriteLine("\nCircle of red border");
            redCircle.Draw();

            Console.WriteLine("\nRectangle of red border");
            redRectangle.Draw();
        }
    }
}
