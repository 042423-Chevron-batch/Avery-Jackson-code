using System;
using System.Collections.Generic;

namespace StoreApiModels
{
    public class Customer
    {
        public Customer() { }

        public Guid CustomerId { get; set; } = Guid.NewGuid();
        public List<CheckoutProduct> Cart { get; } = new List<CheckoutProduct>();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public Customer(int CustomerId, string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public void AddToCart(Product product, int quantity)
        {
            Cart.Add(new CheckoutProduct(product, quantity));
        }
    }
}
