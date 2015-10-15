using DesignPatterns.Interfaces;

namespace DesignPatterns.StrategyPattern
{
    public class SubstractOperation : IStrategy
    {
        public DesignPatterns.Interfaces.IStrategy IStrategy
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
            return num1 - num2;
        }
    }
}
