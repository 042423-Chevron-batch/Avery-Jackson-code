using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApiModels
{
    public class CheckoutProduct
    {
         public Product Product { get; }
    public int Quantity { get; }

    public CheckoutProduct(Product product, int quantity)
        {
        Product = product;
        Quantity = quantity;
        }
    }
}