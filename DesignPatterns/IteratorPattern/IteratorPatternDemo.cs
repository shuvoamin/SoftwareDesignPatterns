using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.IteratorPattern
{
    public class IteratorPatternDemo
    {
        public NameRepository NameRepository
        {
            get
            {
                throw new NotImplementedException();
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
