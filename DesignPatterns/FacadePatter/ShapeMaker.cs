using DesignPatterns.Interfaces;

namespace DesignPatterns.FacadePatter
{
    public class ShapeMaker
    {
        private IShape _circle;
        private IShape _rectangle;
        private IShape _square;

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
            set
            {
            }
        }

        public SquareFacade SquareFacade
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public RectangleFacade RectangleFacade
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
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
