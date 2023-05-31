using System;
using System.Collections.Generic;

namespace StoreApiModels
{
    public class Order
    {
        private static int nextOrderId = 1;
        private Customer customer;
        private Store store;

        public int OrderId { get; }
        public DateTime OrderDate { get; }
        public int CustomerId { get; }
        public string StoreName { get; }
        public List<Product> Products { get; }

        public Order(int customerId, string storeName)
        {
            OrderId = nextOrderId++;
            OrderDate = DateTime.Now;
            CustomerId = customerId;
            StoreName = storeName;
            Products = new List<Product>();
        }

        public Order(Customer customer, Store store)
        {
            this.customer = customer;
            this.store = store;
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
    }
}
