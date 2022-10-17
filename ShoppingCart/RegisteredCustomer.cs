using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class RegisteredCustomer:Customer
    {
        public int Discount { get; }
        public RegisteredCustomer(int discount)
        {
            this.Discount = discount;
        }
        public override double GetTotalOrderValue()
        {
            double total = 0;
            var ordervalue = base.GetTotalOrderValue();
            var discount = ordervalue * this.Discount/100;
            total = ordervalue - discount;
            return total;
        }
    }
}
