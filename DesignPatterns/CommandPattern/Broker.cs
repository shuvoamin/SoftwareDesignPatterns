using DesignPatterns.Interfaces;
using System.Collections.Generic;

namespace DesignPatterns.CommandPattern
{
    public class Broker
    {
        private readonly List<IOrder> _orderList = new List<IOrder>();

        public SellStock SellStock
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        internal BuyStock BuyStock
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public void TakeOrder(IOrder order)
        {
            _orderList.Add(order);
        }

        public void PlaceOrders()
        {
            foreach (var order in _orderList)
            {
                order.Execute();
            }

            _orderList.Clear();
        }
    }
}
