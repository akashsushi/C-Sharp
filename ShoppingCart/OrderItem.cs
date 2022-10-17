using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class OrderItem
    {
        public Product Product { get; set; }
        public int Qty { get; set; }
        public double GetAmount()
        {
            return this.Product.ProductPrice * this.Qty;
        }
    }
}
