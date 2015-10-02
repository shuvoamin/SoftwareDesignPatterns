using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IteratorPattern
{
    public class IteratorPatternDemo
    {
        public NameRepository NameRepository
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public static void Output()
        {
            NameRepository namesRepository = new NameRepository();

            for (IIterator iter = namesRepository.GetIterator(); iter.HasNext(); )
            {
                String name = (String)iter.Next();
                Console.WriteLine("Name : " + name + Environment.NewLine);
            }
        }
    }
}
