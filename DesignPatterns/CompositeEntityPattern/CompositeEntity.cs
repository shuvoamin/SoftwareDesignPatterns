using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CompositeEntityPattern
{
    public class CompositeEntity
    {
        private CoarseGainedObject cgo = new CoarseGainedObject();

        public CoarseGainedObject CoarseGainedObject
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void SetData(string data1, string data2)
        {
            cgo.SetData(data1, data2);
        }

        public String[] GetData()
        {
            return cgo.getData();
        }
    }
}
