using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApiModels
{
    public class Product
    {
         public string Name { get; }
        public double Price { get; }
        public int Quantity {get; set;}
         public string Description {get;}

    public Product(string name, double price, string description, int quantity)
    {
        Name = name;
        Price = price;
        Description = description;
        Quantity = quantity;
    }
    }
}