using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
