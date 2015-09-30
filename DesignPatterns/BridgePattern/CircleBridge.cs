using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BridgePattern
{
    public class CircleBridge : ShapeBridge
    {
        private int _x, _y, _radius;

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
            _drawApi.DrawCircle(_radius, _x, _y);
        }
    }
}
