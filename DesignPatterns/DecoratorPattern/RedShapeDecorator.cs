using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.DecoratorPattern
{
    class RedShapeDecorator :ShapeDecorator
    {
        public RedShapeDecorator(IShape decoratedShape)
            :base(decoratedShape)
        {
        }

        //Override
        public new void Draw()
        {
            DecoratedShape.Draw();
        }

        public void SetRedBorder(IShape decoratedShape)
        {
            Console.WriteLine("Border Color: Red" + Environment.NewLine);
        }
    }
}
