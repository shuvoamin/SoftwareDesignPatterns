using System;

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
            set
            {
            }
        }
    
        public static void Output()
        {
            var context = new ContextStrategy(new AddOperation());
            Console.WriteLine("10 + 5 = " + context.ExecuteStrategy(10, 5) + Environment.NewLine);

            context = new ContextStrategy(new SubstractOperation());
            Console.WriteLine("10 - 5 = " + context.ExecuteStrategy(10, 5) + Environment.NewLine);

            context = new ContextStrategy(new MultiplyOperation());
            Console.WriteLine("10 * 5 = " + context.ExecuteStrategy(10, 5) + Environment.NewLine);
        }
    }
}
