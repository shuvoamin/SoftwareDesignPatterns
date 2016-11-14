using DesignPatterns.Interfaces;
using System;
using System.Diagnostics;

namespace DesignPatterns.ProxyPattern
{
    public class RealImage : IImage
    {
        private readonly string _fileName;

        public RealImage(string fileName)
        {
            _fileName = fileName;
        }

        public IImage Image
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void LoadFromDisk(string fileName)
        {
            Trace.WriteLine("Loading :" + fileName + Environment.NewLine);
        }

        //Override
        public void Display()
        {
            Trace.WriteLine("Displaying :" + _fileName + Environment.NewLine);
        }
    }
}
