using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.BridgePattern
{
    public class GreenCircle : IDrawApi
    {
        public IDrawApi IDrawApi
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }
        //Override
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Drawing circle [ color: green, radius: " + radius + ", x: " + x + ", y: " + y + "]" + Environment.NewLine);
        }
    }
}
