using DesignPatterns.Interfaces;

namespace DesignPatterns.BridgePattern
{
    public abstract class ShapeBridge
    {
        protected IDrawApi DrawApiShapeBridge;

        protected ShapeBridge(IDrawApi drawApi)
        {
            DrawApiShapeBridge = drawApi;
        }

        public IDrawApi DrawApi
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public abstract void Draw();
    }
}
