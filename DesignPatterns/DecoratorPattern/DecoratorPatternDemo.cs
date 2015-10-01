using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    public class DecoratorPatternDemo
    {
        public ShapeDecorator ShapeDecorator
        {
            get
            {
                throw new System.NotImplementedException();
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
