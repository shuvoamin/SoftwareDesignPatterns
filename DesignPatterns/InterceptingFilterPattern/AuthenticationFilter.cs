using DesignPatterns.Interfaces;
using System;

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
            Console.WriteLine("Authenticating request: " + request + Environment.NewLine);
        }
    }
}
