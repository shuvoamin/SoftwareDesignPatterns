using DesignPatterns.Interfaces;

namespace DesignPatterns.StrategyPattern
{
    public class ContextStrategy
    {
        private readonly IStrategy _strategy;

        public ContextStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public MultiplyOperation MultiplyOperation
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public SubstractOperation SubstractOperation
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public AddOperation AddOperation
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public int ExecuteStrategy(int num1, int num2)
        {
            return _strategy.DoOperation(num1, num2);
        }
    }
}
