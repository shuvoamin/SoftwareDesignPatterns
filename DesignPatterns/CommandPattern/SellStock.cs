using DesignPatterns.Interfaces;

namespace DesignPatterns.CommandPattern
{
    public class SellStock : IOrder
    {
        private readonly Stock _abcStock;

        public SellStock(Stock abcStock)
        {
            _abcStock = abcStock;
        }

        public IOrder Order
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        //Override
        public void Execute()
        {
            _abcStock.Sell();
        }
    }
}
