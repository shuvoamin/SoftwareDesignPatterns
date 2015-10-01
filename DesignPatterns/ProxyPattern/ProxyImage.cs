using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ProxyPattern
{
    public class ProxyImage : IImage
    {
        private RealImage _realImage;
        private string _fileName;

        public ProxyImage(string fileName)
        {
            _fileName = fileName;
        }

        public DesignPatterns.Interfaces.IImage IImage
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
        public void Display()
        {
            if (_realImage == null)
            {
                _realImage = new RealImage(_fileName);
            }

            _realImage.Display();
        }
    }
}
