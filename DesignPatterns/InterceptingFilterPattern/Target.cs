using System;
using System.Diagnostics;

namespace DesignPatterns.InterceptingFilterPattern
{
    public class Target
    {
        public void Execute(string request)
        {
            Trace.WriteLine("Executing request: " + request + Environment.NewLine);
        }
    }
}
