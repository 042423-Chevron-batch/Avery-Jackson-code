using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApiModels
{
    public class Store
    {
         public string storename { get; }
    public List<Product> Products { get; }

    public Store(string storeName, List<Product> products)
    {
        storename = storeName;
        Products = products;
    }
    
    }
}