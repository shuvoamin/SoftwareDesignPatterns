using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CompositeEntityPattern
{
    public class DependentObject1
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
