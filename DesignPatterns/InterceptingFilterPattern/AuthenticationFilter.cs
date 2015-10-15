using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.InterceptingFilterPattern
{
    public class AuthenticationFilter : IFilter
    {
        public IFilter IFilter
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }
        //Override
        public void Execute(string request)
        {
            Console.WriteLine("Authenticating request: " + request + Environment.NewLine);
        }
    }
}
