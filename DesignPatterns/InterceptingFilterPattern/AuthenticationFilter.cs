using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.InterceptingFilterPattern
{
    public class AuthenticationFilter : IFilter
    {
        public DesignPatterns.Interfaces.IFilter IFilter
        {
            get
            {
                throw new System.NotImplementedException();
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
