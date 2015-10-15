using System;

namespace DesignPatterns.CompositeEntityPattern
{
    public class DependentObject2
    {
        private string _data;

        public void SetData(String data)
        {
            _data = data;
        }

        public String GetData()
        {
            return _data;
        }
    }
}
