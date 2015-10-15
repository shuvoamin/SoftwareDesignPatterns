using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.FlyweightPattern
{
    public class CircleFlyweight : IShape
    {
        private string _color;
        private int _x;
        private int _y;
        private int _radius;

        public CircleFlyweight(string color)
        {
            _color = color;		
        }

        #region X, Y, Radius Getter/Setter
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public int Radius
        {
            get { return _radius; }
            set { _radius = value; }
        } 
        #endregion

        public DesignPatterns.Interfaces.IShape IShape
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        //Override
        public void Draw()
        {
            Console.WriteLine("Circle: Draw() [Color : " + _color + ", x : " + X + ", y :" + Y + ", radius :" + Radius);
        }
    }
}
