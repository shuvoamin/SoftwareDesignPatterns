namespace DesignPatterns.CommandPattern
{
    public class CommandPatternDemo
    {
        public Broker Broker
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Stock Stock
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public static void Output()
        {
            Stock abcStock = new Stock();

            BuyStock buyStockOrder = new BuyStock(abcStock);
            SellStock sellStockOrder = new SellStock(abcStock);

            Broker broker = new Broker();
            broker.TakeOrder(buyStockOrder);
            broker.TakeOrder(sellStockOrder);

            broker.PlaceOrders();
        }
    }
}
