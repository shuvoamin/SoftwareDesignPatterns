﻿using System;
using System.Diagnostics;
using DesignPatterns.Interfaces;

namespace DesignPatterns.FactoryPattern
{
    public class Rectangle : IShape
    {
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
            Trace.WriteLine("Inside Rectangle::Draw() method." + Environment.NewLine);
        }
    }
}
