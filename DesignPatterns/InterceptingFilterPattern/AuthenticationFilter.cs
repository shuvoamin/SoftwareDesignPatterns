using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
