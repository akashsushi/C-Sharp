using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string MobileNo { get; set; }
        public Company Company { get; set; }

        private List<Order> orders = new List<Order>();

        /// <summary>
        /// Method to add orders of customer
        /// </summary>
        /// <param name="order"></param>
        public void AddOrder(Order order)
        {
          this.orders.Add(order);
        }

        /// <summary>
        /// Method to get all the orders by the customer
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Order> GetOrders()
        {
            return this.orders;
        }
        public virtual double GetTotalOrderValue()
        {
            double total = 0;
            foreach(var order in this.orders)
            {
                total += order.GetOrderTotal();
            }
            return total;
        }

    }
}
