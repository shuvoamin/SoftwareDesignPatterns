using DesignPatterns.Interfaces;

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
