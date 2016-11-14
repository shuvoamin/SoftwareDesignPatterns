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
        }

        public Stock Stock
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }
    
        public static void Output()
        {
            var abcStock = new Stock();

            var buyStockOrder = new BuyStock(abcStock);
            var sellStockOrder = new SellStock(abcStock);

            var broker = new Broker();
            broker.TakeOrder(buyStockOrder);
            broker.TakeOrder(sellStockOrder);

            broker.PlaceOrders();
        }
    }
}
