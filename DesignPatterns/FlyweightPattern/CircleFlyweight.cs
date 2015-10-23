using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.FlyweightPattern
{
    public class CircleFlyweight : IShape
    {
        private readonly string _color;

        public CircleFlyweight(string color)
        {
            _color = color;		
        }

        #region X, Y, Radius Getter/Setter
        public int X { get; set; }

        public int Y { get; set; }

        public int Radius { get; set; }
        #endregion

        public IShape Shape
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        //Override
        public void Draw()
        {
            Console.WriteLine("Circle: Draw() [Color : " + _color + ", x : " + X + ", y :" + Y + ", radius :" + Radius);
        }
    }
}
