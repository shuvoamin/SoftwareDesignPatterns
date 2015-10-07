using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.InterceptingFilterPattern
{
    public class Target
    {
        public void Execute(string request)
        {
            Console.WriteLine("Executing request: " + request + Environment.NewLine);
        }
    }
}
