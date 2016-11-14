using DesignPatterns.Interfaces;

namespace DesignPatterns.BridgePattern
{
    public class CircleBridge : ShapeBridge
    {
        private readonly int _x, _y, _radius;

        public CircleBridge(int x, int y, int radius, IDrawApi drawApi)
            :base(drawApi)
        {
            _x = x;
            _y = y;
            _radius = radius;
        }

        //Override
        public override void Draw()
        {
            DrawApiShapeBridge.DrawCircle(_radius, _x, _y);
        }
    }
}
