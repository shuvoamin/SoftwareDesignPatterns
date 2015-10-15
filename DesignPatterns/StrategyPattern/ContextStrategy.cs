using DesignPatterns.Interfaces;

namespace DesignPatterns.StrategyPattern
{
    public class ContextStrategy
    {
        private IStrategy _strategy;

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
            set
            {
            }
        }

        public SubstractOperation SubstractOperation
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public AddOperation AddOperation
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int ExecuteStrategy(int num1, int num2)
        {
            return _strategy.DoOperation(num1, num2);
        }
    }
}
