using DesignPatterns.Interfaces;

namespace DesignPatterns.DecoratorPattern
{
    public class ShapeDecorator : IShape
    {
        protected IShape DecoratedShape;

        public ShapeDecorator(IShape decoratedShape)
        {
            DecoratedShape = decoratedShape;
        }

        public IShape Shape
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        //Overide
        public void Draw()
        {
            DecoratedShape.Draw();
        }
    }
}
