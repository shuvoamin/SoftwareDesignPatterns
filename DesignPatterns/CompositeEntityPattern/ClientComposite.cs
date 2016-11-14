using System;
using System.Diagnostics;

namespace DesignPatterns.CompositeEntityPattern
{
    public class ClientComposite
    {
        private CompositeEntity compositeEntity = new CompositeEntity();

        public CompositeEntity CompositeEntity
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }

        public void PrintData()
        {
            for (var i = 0; i < compositeEntity.GetData().Length; i++)
            {
                Trace.WriteLine("Data: " + compositeEntity.GetData()[i] + Environment.NewLine);
            }
        }

        public void SetData(string data1, string data2)
        {
            compositeEntity.SetData(data1, data2);
        }
    }
}
