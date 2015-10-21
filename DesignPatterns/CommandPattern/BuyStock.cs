using DesignPatterns.Interfaces;

namespace DesignPatterns.CommandPattern
{
    class BuyStock : IOrder
    {
        private readonly Stock _abcStock;

        public BuyStock(Stock abcStock)
        {
            _abcStock = abcStock;
        }

        public IOrder Order
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void Execute()
        {
            _abcStock.Buy();
        }
    }
}
