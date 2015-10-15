using DesignPatterns.Interfaces;

namespace DesignPatterns.BridgePattern
{
    public abstract class ShapeBridge
    {
        protected IDrawApi _drawApi;

        protected ShapeBridge(IDrawApi drawApi)
        {
            _drawApi = drawApi;
        }

        public IDrawApi IDrawApi
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public abstract void Draw();
    }
}
