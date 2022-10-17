using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }

        private List<OrderItem> orderItems = new List<OrderItem>();
        public void AddOrderItem(OrderItem orderItem)
        {
            this.orderItems.Add(orderItem);
        }
        public IEnumerable<OrderItem> GetOrderItem()
        {
            return this.orderItems;
        }

        /// <summary>
        /// Method to get Order Total
        /// </summary>
        /// <returns></returns>
        public double GetOrderTotal()
        {
            double total = 0;
            foreach(var orderItem in this.orderItems)
            {
                total += orderItem.GetAmount();
            }
            return total;
        }
    }
}
