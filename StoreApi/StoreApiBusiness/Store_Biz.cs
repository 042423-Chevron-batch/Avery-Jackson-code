using System.Collections.Generic;
using System.Linq;
using StoreApiModels;
using StoreApiRespository;

namespace StoreApiBusiness
{
    public class Store_Biz
    {
     

        // Place an order to a store location for a customer
        public void PlaceOrder(int customerId, string storeName, List<Product> items)
        {
            // Retrieve customer and store information from repositories
            Customer customer = Repository.GetCustomerById(customerId);
            Store store = Repository.GetStore(storeName);

            // Create a new order
            Order order = new Order(customer, store);

            // Add the order to the order repository
            Repository.AddOrder(order);

          
        }

        // Add a new customer
        public void AddCustomer(Customer customer)
        {
            Repository.AddCustomer(customer);
        }

        // Search customers by name
        public List<Customer> SearchCustomersByName(string name)
        {
            return Repository.SearchCustomersByName(name);
        }

        // Display details of an order
        public Order GetOrderDetails(int orderId)
        {
            return Repository.GetOrderById(orderId);
        }

        // Display all order history of a store location
        public List<Order> GetStoreOrderHistory(string storeName)
        {
            return Repository.GetOrdersByStore(storeName);
        }

        // Display all order history of a customer
        public List<Order> GetCustomerOrderHistory(int customerId)
        {
            return Repository.GetOrdersByCustomerId(customerId);
        }
    }
}

