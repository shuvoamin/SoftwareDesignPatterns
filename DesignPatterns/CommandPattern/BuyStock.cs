using DesignPatterns.Interfaces;

namespace DesignPatterns.CommandPattern
{
    class BuyStock : IOrder
    {
        private Stock _abcStock;

        public BuyStock(Stock abcStock)
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

        public void Execute()
        {
            _abcStock.Buy();
        }
    }
}
