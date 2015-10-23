using System;
using System.Diagnostics;

namespace DesignPatterns.StrategyPattern
{
    public class StrategyPatternDemo
    {
        public ContextStrategy ContextStrategy
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    
        public static void Output()
        {
            var context = new ContextStrategy(new AddOperation());
            Trace.WriteLine("10 + 5 = " + context.ExecuteStrategy(10, 5) + Environment.NewLine);

            context = new ContextStrategy(new SubstractOperation());
            Trace.WriteLine("10 - 5 = " + context.ExecuteStrategy(10, 5) + Environment.NewLine);

            context = new ContextStrategy(new MultiplyOperation());
            Trace.WriteLine("10 * 5 = " + context.ExecuteStrategy(10, 5) + Environment.NewLine);
        }
    }
}
