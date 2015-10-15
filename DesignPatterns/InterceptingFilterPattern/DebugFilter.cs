using DesignPatterns.Interfaces;
using System;

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
