using DesignPatterns.Interfaces;
using System;
using System.Diagnostics;

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
        }
    
        public static void Output()
        {
            IShape circle = new CircleDecorator();

            IShape redCircle = new RedShapeDecorator(new CircleDecorator());

            IShape redRectangle = new RedShapeDecorator(new RectangleDecorator());
            Trace.WriteLine("Circle with normal border");
            circle.Draw();

            Trace.WriteLine("\nCircle of red border");
            redCircle.Draw();

            Trace.WriteLine("\nRectangle of red border");
            redRectangle.Draw();
        }
    }
}
