using System;
using System.Diagnostics;

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
        }
    
        public static void Output()
        {
            var namesRepository = new NameRepository();

            for (var iter = namesRepository.GetIterator(); iter.HasNext(); )
            {
                var name = (string)iter.Next();
                Trace.WriteLine("Name : " + name + Environment.NewLine);
            }
        }
    }
}
