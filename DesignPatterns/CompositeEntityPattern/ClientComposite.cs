using System;

namespace DesignPatterns.CompositeEntityPattern
{
    public class ClientComposite
    {
        private CompositeEntity compositeEntity = new CompositeEntity();

        public CompositeEntity CompositeEntity
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void PrintData()
        {
            for (int i = 0; i < compositeEntity.GetData().Length; i++)
            {
                Console.WriteLine("Data: " + compositeEntity.GetData()[i] + Environment.NewLine);
            }
        }

        public void SetData(String data1, String data2)
        {
            compositeEntity.SetData(data1, data2);
        }
    }
}
