using DesignPatterns.Interfaces;

namespace DesignPatterns.StrategyPattern
{
    public class MultiplyOperation : IStrategy
    {
        public IStrategy IStrategy
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
        public int DoOperation(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
