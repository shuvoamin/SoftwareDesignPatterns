using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.BridgePattern
{
    public class RedCircle : IDrawApi
    {
        public IDrawApi DrawApi
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        //Override
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Drawing circle [ color: red, radius: " + radius + ", x: " + x + ", y: " + y + "]" + Environment.NewLine);
        }
    }
}
