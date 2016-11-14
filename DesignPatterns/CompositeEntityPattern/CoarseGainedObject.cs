using System;

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
                throw new NotImplementedException();
            }
            set
            {
            }
        }

        public DependentObject2 DependentObject2
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }

        public void SetData(string data1, string data2)
        {
            do1.SetData(data1);
            do2.SetData(data2);
        }

        public string[] getData()
        {
            return new string[] { do1.GetData(), do2.GetData() };
        }
    }
}
