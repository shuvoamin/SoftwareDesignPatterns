using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ProxyPattern
{
    public class ProxyPatternDemo
    {
        public RealImage RealImage
        {
            get
            {
                throw new System.NotImplementedException();
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
