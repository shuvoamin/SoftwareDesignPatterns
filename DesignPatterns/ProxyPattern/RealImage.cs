using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.ProxyPattern
{
    public class RealImage : IImage
    {
        private string _fileName;

        public RealImage(string fileName)
        {
            _fileName = fileName;
        }

        public IImage IImage
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }

        public void LoadFromDisk(string fileName)
        {
            Console.WriteLine("Loading :" + fileName + Environment.NewLine);
        }

        //Override
        public void Display()
        {
            Console.WriteLine("Displaying :" + _fileName + Environment.NewLine);
        }
    }
}
