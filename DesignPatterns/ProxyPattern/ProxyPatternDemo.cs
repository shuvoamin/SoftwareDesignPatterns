using DesignPatterns.Interfaces;
using System;

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
            set
            {
            }
        }
    
        public static void Output()
        {
            IImage image = new ProxyImage("test_10mb.jpg");

            //image will be loaded from disk
            image.Display();
            Console.WriteLine("" + Environment.NewLine);

            //image will not be loaded from disk
            image.Display();
        }
    }
}
