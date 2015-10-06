using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CompositeEntityPattern
{
    public class CoarseGainedObject
    {
        DependentObject1 do1 = new DependentObject1();
        DependentObject2 do2 = new DependentObject2();

        public DependentObject1 DependentObject1
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public DependentObject2 DependentObject2
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void SetData(String data1, String data2)
        {
            do1.SetData(data1);
            do2.SetData(data2);
        }

        public String[] getData()
        {
            return new String[] { do1.GetData(), do2.GetData() };
        }
    }
}
