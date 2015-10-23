using DesignPatterns.Interfaces;

namespace DesignPatterns.ProxyPattern
{
    public class ProxyImage : IImage
    {
        private RealImage _realImage;
        private readonly string _fileName;

        public ProxyImage(string fileName)
        {
            _fileName = fileName;
        }

        public IImage Image
        {
            get
            {
                throw new System.NotImplementedException();
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
