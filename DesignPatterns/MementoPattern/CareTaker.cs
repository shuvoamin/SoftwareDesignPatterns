using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MementoPattern
{
    public class CareTaker
    {
        private List<Memento> mementoList = new List<Memento>();

        public Memento Memento
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void Add(Memento state)
        {
            mementoList.Add(state);
        }

        public Memento Get(int index)
        {
            return mementoList[index];
        }
    }
}
