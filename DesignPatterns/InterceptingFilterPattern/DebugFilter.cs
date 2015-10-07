using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.InterceptingFilterPattern
{
    public class DebugFilter : IFilter
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
            Console.WriteLine("request log: " + request + Environment.NewLine);
        }
    }
}
