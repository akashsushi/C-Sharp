using System;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create Products
            Product product1 = new Product() { ProductId = 101, ProductName = "Nike Jumpman Shoes", ProductPrice = 12000 };
            Product product2 = new Product() { ProductId = 102, ProductName = "Straw Hat", ProductPrice = 600 };
            Product product3 = new Product() { ProductId = 103, ProductName = "Shusui", ProductPrice = 340000 };
            Product product4 = new Product() { ProductId = 104, ProductName = "Wano 11s", ProductPrice = 6000 };
            Product product5 = new Product() { ProductId = 105, ProductName = "Reebok Tank Top", ProductPrice = 1200 };
            Product product6 = new Product() { ProductId = 106, ProductName = "Wallet", ProductPrice = 1500 };

            //2.Create Company
            Company company = new Company() { CompanyId = 1, CompanyName = "ShopOn" };

            //3.Add Products to the Company
            company.AddProduct(product1);
            company.AddProduct(product2);
            company.AddProduct(product4);
            company.AddProduct(product5);
            company.AddProduct(product6);

            //4.Create Customer
            Customer customer1 = new Customer() { CustomerId = 200, CustomerName = "Joyboy", MobileNo = "9673325463" };
            Customer customer2 = new Customer() { CustomerId = 201, CustomerName = "Zoro", MobileNo = "9671313254" };
            Customer customer3 = new RegisteredCustomer(10) { CustomerId = 202, CustomerName = "Nami", MobileNo = "9671000463" };

            //5.Add Customer to the Company
            company.AddCustomer(customer1);
            company.AddCustomer(customer2);
            company.AddCustomer(customer3);

            //6.Add Company to the Customer
            customer1.Company = company;

            //7.Create Order
            Order order1 = new Order() { OrderId = 1000, OrderDate = DateTime.UtcNow };
            Order order2 = new Order() { OrderId = 1001, OrderDate = DateTime.UtcNow };
            Order order3 = new Order() { OrderId = 1002, OrderDate = DateTime.UtcNow };
            Order order4 = new Order() { OrderId = 1003, OrderDate = DateTime.UtcNow };
            Order order5 = new Order() { OrderId = 1004, OrderDate = DateTime.UtcNow };
            Order order6 = new Order() { OrderId = 1005, OrderDate = DateTime.UtcNow };

            //8.Add Order to Customer
            order1.Customer = customer1;
            order2.Customer = customer3;
            order3.Customer = customer2;
            order4.Customer = customer3;
            order5.Customer = customer1;
            order6.Customer = customer2;

            //9.Add Customer to Order
            customer1.AddOrder(order1);
            customer1.AddOrder(order5);
            customer2.AddOrder(order3);
            customer2.AddOrder(order6);
            customer3.AddOrder(order2);
            customer3.AddOrder(order4);

            //10.Create OrderItem
            OrderItem orderItem1 = new OrderItem() { Qty = 1 };
            OrderItem orderItem2 = new OrderItem() { Qty = 2 };
            OrderItem orderItem3 = new OrderItem() { Qty = 3 };
            OrderItem orderItem4 = new OrderItem() { Qty = 1 };
            OrderItem orderItem5 = new OrderItem() { Qty = 4 };
            OrderItem orderItem6 = new OrderItem() { Qty = 2 };
            OrderItem orderItem7 = new OrderItem() { Qty = 1 };

            //11.Add Products to OrderItem
            orderItem1.Product = product1;
            orderItem2.Product = product2;
            orderItem3.Product = product3;
            orderItem4.Product = product4;
            orderItem5.Product = product5;
            orderItem6.Product = product6;
            orderItem7.Product = product4;

            //12.Add OrderItem to Order
            order1.AddOrderItem(orderItem1);
            order1.AddOrderItem(orderItem2);
            order2.AddOrderItem(orderItem6);
            order3.AddOrderItem(orderItem3);
            order4.AddOrderItem(orderItem5);
            order5.AddOrderItem(orderItem4);
            order6.AddOrderItem(orderItem7);


            //13.Display Company Details
            DisplayCompany(company);
        }

        private static void DisplayCompany(Company company)
        {
            Console.WriteLine("Company Data");
            DrawLine(25, "-");
            Console.WriteLine($"Company Id:{company.CompanyId}\t\tCompany Name:{company.CompanyName}");
            DrawLine(45, "-");
            foreach(var customer in company.GetCustomers())
            {   
                Console.WriteLine($"Customer Id:{customer.CustomerId}\t\tCustomer Name:{customer.CustomerName}");
                Console.WriteLine($"Total Customer Value:\t\t{customer.GetTotalOrderValue()}");
                DrawLine(45, "-");
                foreach(var order in customer.GetOrders())
                {
                    Console.WriteLine($"Order Id:{order.OrderId}\t\tOrder Date:{order.OrderDate}");
                    Console.WriteLine("Pid\tPname\t\tPrice\tQty\tAmount");
                    DrawLine(45, "-");
                    foreach (var orderItem in order.GetOrderItem())
                    {
                        Console.WriteLine($"{orderItem.Product.ProductId}\t{orderItem.Product.ProductName} \t" +
                            $"{orderItem.Product.ProductPrice}\t{orderItem.Qty}\t{orderItem.GetAmount()}");
                    }
                    DrawLine(45, "-");
                    Console.WriteLine($"Order Total:\t\t{order.GetOrderTotal()}");
                    DrawLine(45, "-");
                }
                DrawLine(45, "=");
                Console.WriteLine();
                
            }
        }

        private static void DrawLine(int count, string pattern)
        {
            int i = 0;
            while(i < count)
            {
                Console.Write($"{pattern}");
                i++;
            }
            Console.WriteLine();
        }
    }
}
