using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.InterceptingFilterPattern
{
    public class DebugFilter : IFilter
    {
        public IFilter Filter
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        //Override
        public void Execute(string request)
        {
            Console.WriteLine("request log: " + request + Environment.NewLine);
        }
    }
}
