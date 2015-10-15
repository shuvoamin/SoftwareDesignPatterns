using System;

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
