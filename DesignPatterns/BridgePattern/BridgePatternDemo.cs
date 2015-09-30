using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BridgePattern
{
    public class BridgePatternDemo
    {
        public static void Output()
        {
            ShapeBridge redCircle = new CircleBridge(100, 100, 10, new RedCircle());
            ShapeBridge greenCircle = new CircleBridge(100, 100, 10, new GreenCircle());

            redCircle.Draw();
            greenCircle.Draw();
        }
    }
}
