using DesignPatterns.Interfaces;
using System;
using System.Diagnostics;

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
            Trace.WriteLine("request log: " + request + Environment.NewLine);
        }
    }
}
