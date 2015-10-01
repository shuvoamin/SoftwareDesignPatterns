using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    public class ShapeDecorator : IShape
    {
        protected IShape _decoratedShape;

        public ShapeDecorator(IShape decoratedShape)
        {
            _decoratedShape = decoratedShape;
        }

        public DesignPatterns.Interfaces.IShape IShape
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        //Overide
        public void Draw()
        {
            _decoratedShape.Draw();
        }
    }
}
