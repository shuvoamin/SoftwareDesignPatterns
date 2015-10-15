using DesignPatterns.Interfaces;

namespace DesignPatterns.CommandPattern
{
    public class SellStock : IOrder
    {
        private Stock _abcStock;

        public SellStock(Stock abcStock)
        {
            _abcStock = abcStock;
        }

        public IOrder IOrder
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
        public void Execute()
        {
            _abcStock.Sell();
        }
    }
}
