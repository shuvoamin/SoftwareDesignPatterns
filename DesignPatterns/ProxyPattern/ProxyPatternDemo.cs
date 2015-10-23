using DesignPatterns.Interfaces;
using System;
using System.Diagnostics;

namespace DesignPatterns.ProxyPattern
{
    public class ProxyPatternDemo
    {
        public RealImage RealImage
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    
        public static void Output()
        {
            IImage image = new ProxyImage("test_10mb.jpg");

            //image will be loaded from disk
            image.Display();
            Trace.WriteLine("" + Environment.NewLine);

            //image will not be loaded from disk
            image.Display();
        }
    }
}
