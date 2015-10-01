using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    class RedShapeDecorator :ShapeDecorator
    {
        public RedShapeDecorator(IShape decoratedShape)
            :base(decoratedShape)
        {
        }

        //Override
        public void Draw()
        {
            _decoratedShape.Draw();
        }

        private void SetRedBorder(IShape decoratedShape)
        {
            Console.WriteLine("Border Color: Red" + Environment.NewLine);
        }
    }
}
