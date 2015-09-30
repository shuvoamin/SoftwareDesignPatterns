using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.BridgePattern
{
    public class GreenCircle : IDrawApi
    {
        //Override
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Drawing circle [ color: green, radius: " + radius + ", x: " + x + ", y: " + y + "]" + Environment.NewLine);
        }
    }
}
