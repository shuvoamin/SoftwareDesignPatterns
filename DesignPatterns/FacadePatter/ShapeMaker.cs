using DesignPatterns.Interfaces;

namespace DesignPatterns.FacadePatter
{
    public class ShapeMaker
    {
        private readonly IShape _circle;
        private readonly IShape _rectangle;
        private readonly IShape _square;

        public ShapeMaker()
        {
            _circle = new CircleFacade();
            _rectangle = new RectangleFacade();
            _square = new RectangleFacade();
        }

        public CircleFacade CircleFacade
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public SquareFacade SquareFacade
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public RectangleFacade RectangleFacade
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public void DrawCircle()
        {
            _circle.Draw();
        }

        public void DrawSquare()
        {
            _square.Draw();
        }

        public void DrawRectangle()
        {
            _rectangle.Draw();
        }
    }
}
