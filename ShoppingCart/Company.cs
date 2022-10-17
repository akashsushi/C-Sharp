using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }

        private List<Product> products = new List<Product>();

        private List<Customer> customers = new List<Customer>();

        /// <summary>
        /// Method to add product to company
        /// </summary>
        /// <param name="product"></param>
        public void AddProduct(Product product)
        {
            this.products.Add(product);
        }

        /// <summary>
        /// Method to get all products
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Product> GetProducts()
        {
            return this.products;
        }

        /// <summary>
        /// Method to customer to company
        /// </summary>
        /// <param name="customer"></param>
        public void AddCustomer(Customer customer)
        {
            this.customers.Add(customer);
        }

        /// <summary>
        /// Method to get all customers
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Customer> GetCustomers()
        {
            return this.customers;
        }
    }
}
