using DesignPatterns.Interfaces;
using System.Collections.Generic;

namespace DesignPatterns.CommandPattern
{
    public class Broker
    {
        private List<IOrder> _orderList = new List<IOrder>();

        public SellStock SellStock
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal BuyStock BuyStock
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void TakeOrder(IOrder order)
        {
            _orderList.Add(order);
        }

        public void PlaceOrders()
        {
            foreach (IOrder order in _orderList)
            {
                order.Execute();
            }

            _orderList.Clear();
        }
    }
}
