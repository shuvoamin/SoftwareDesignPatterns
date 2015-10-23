using DesignPatterns.Interfaces;
using System;
using System.Diagnostics;

namespace DesignPatterns.InterceptingFilterPattern
{
    public class AuthenticationFilter : IFilter
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
            Trace.WriteLine("Authenticating request: " + request + Environment.NewLine);
        }
    }
}
