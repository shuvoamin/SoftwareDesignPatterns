using DesignPatterns.Interfaces;
using System;
using System.Diagnostics;

namespace DesignPatterns.DecoratorPattern
{
    class RedShapeDecorator : ShapeDecorator
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
            Trace.WriteLine("Border Color: Red" + Environment.NewLine);
        }
    }
}
