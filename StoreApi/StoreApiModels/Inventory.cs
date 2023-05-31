using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApiModels
{
    public class Inventory
    {
        private List<Order> orders;
        private List<Product> products;

        public Inventory()
        {
            orders = new List<Order>();
            products = new List<Product>();
        }

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void AcceptOrders()
{
    foreach (var order in orders)
    {
        bool acceptOrder = true;

        foreach (var product in order.Products)
        {
            var orderProduct = products.FirstOrDefault(p => p.Name == product.Name);

            if (orderProduct != null && orderProduct.Quantity >= product.Quantity)
            {
                orderProduct.Quantity -= product.Quantity;
            }
            else
            {
                acceptOrder = false;
                break;
            }
        }

        if (acceptOrder)
        {
            Console.WriteLine($"Order #{order.OrderId} has been accepted.");
        }
        else
        {
            Console.WriteLine($"Order #{order.OrderId} has been rejected due to insufficient inventory.");
        }
    }
}
}
}
