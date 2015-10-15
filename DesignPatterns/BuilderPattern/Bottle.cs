using DesignPatterns.Interfaces;

namespace DesignPatterns.BuilderPattern
{
    public class Bottle : IPacking
    {
        public DesignPatterns.Interfaces.IPacking IPacking
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
        public string pack()
        {
            return "Bottle";
        }
    }
}
