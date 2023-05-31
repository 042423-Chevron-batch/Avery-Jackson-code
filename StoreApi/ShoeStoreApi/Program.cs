using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreApiModels;

namespace ShoeStoreApi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>
            {
               // new Customer("avery", "jackson")

            };
            bool exitProgram = false;
            while (!exitProgram)
            {
            Console.WriteLine("Welcome to Hibbetts! Please sign in to begin");
            Console.WriteLine("Enter your first name: ");
            string? Fname = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            string? Lname = Console.ReadLine();

            Customer customer = VerifyCustomer(Fname, Lname, customers);

            while (customer == null)
            {
                Console.WriteLine("Invalid username or password. Please try again.");
                Console.WriteLine("Enter your first name: ");
                Fname = Console.ReadLine();
                Console.WriteLine("Enter your last name: ");
                Lname = Console.ReadLine();
                // customer = VerifyCustomer(username!, password!, customers);
            }
            if(exitProgram) break;

            Console.WriteLine("Login successful!");

            List<Store> stores = new List<Store>
            {
                new Store("Hibbetts", new List<Product>
                {
                    new Product("Jordan", 220.00, "Air Jordan Retro 5's", 10),
                    new Product("Nike", 100.00, "Air Force 1's", 10),
                    new Product("AirMax", 120.00, "VaporMax Flyknit", 10)
                }),
                new Store("CityGear", new List<Product>
                {
                    new Product("Jordan", 110.00, "Air Jordan 1 Low", 10),
                    new Product("Nike", 100.00, "Air Force 1's", 10),
                    new Product("AirMax", 120.00, "VaporMax Flyknit", 10)
                }),
                new Store("SportsAddition", new List<Product>
                {
                    new Product("Jordan", 140.00, "GS Air Jordan Retro 11's", 10),
                    new Product("Nike", 100.00, "Air Force 1's", 10),
                    new Product("AirMax", 120.00, "VaporMax Flyknit", 10)
                })
            };

            // Select which store you want to shop at
            Console.WriteLine("Which location would you like to shop at today: ");
            for (int i = 0; i < stores.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {stores[i].storename}");
            }

            Console.WriteLine("Select your store: ");
            int storeNum = Console.Read() - '0';
            Console.ReadLine();
            Store selectedStore;

            if (storeNum >= 1 && storeNum <= stores.Count)
            {
                selectedStore = stores[storeNum - 1];
                Console.WriteLine($"Selected store: {selectedStore.storename}");
            }
            else
            {
                Console.WriteLine("Invalid store. Please try again.");
                return;
            }


            // List the available items for that store
            Console.WriteLine($"Available Products at {selectedStore.storename}: ");
            foreach (Product product in selectedStore.Products)
            {
                Console.WriteLine($" ${product.Price} - {product.Name} - {product.Description}");
            }

            // Adding things to your cart to checkout
            while (true)
            {
                Console.WriteLine("Enter 'S' to stop shopping or 'V' to view cart.");
                Console.WriteLine("Enter the name of a product to add it to your cart: ");
                string? choice = Console.ReadLine();

                if (choice.ToUpper() == "S")
                {
                    exitProgram = true;
                    break;
                }
                else if (choice.ToUpper() == "V")
                {
                    Console.WriteLine("Products currently in your Cart:");
                    if (customer.Cart.Count == 0)
                    {
                        Console.WriteLine("Your cart is empty. Please start adding to your cart to view products.");
                    }
                    else
                    {
                        foreach (var cartItem in customer.Cart)
                        {
                            Console.WriteLine($"{cartItem.Product.Name} - Quantity: {cartItem.Quantity}");
                        }
                    }
                }
                else
                {
                    Product? selectedProduct = selectedStore.Products.Find(p => p.Name == choice);
                    if (selectedProduct != null)
                    {
                        Console.Write("Enter the quantity: ");
                        int quantity;

                        if (int.TryParse(Console.ReadLine(), out quantity) && quantity >= 1)
                        {
                            customer.AddToCart(selectedProduct, quantity);
                            Console.WriteLine($"{quantity} {selectedProduct.Name}(s) added to cart.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid quantity. Please try again.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid product. Please try again.");
                    }
                }
            }

            // Checkout
            double totalCost = 0;
            Console.WriteLine("Items currently in your cart: ");
            foreach (var cartItem in customer.Cart)
            {
                double itemCost = cartItem.Product.Price * cartItem.Quantity;
                Console.WriteLine($"{cartItem.Product.Name} - Quantity: {cartItem.Quantity} - Cost: ${itemCost}");
                totalCost += itemCost;
            }

            Console.WriteLine($"Your Total Order Cost is: ${totalCost}");
            Console.WriteLine("Thank you for shopping with us today! You will receive a confirmation email for your order soon.");

            Console.ReadLine();
        }
            static Customer VerifyCustomer(string Fname, string Lname, List<Customer> customers)
            {
            foreach (Customer customer in customers)
            {
                if (customer.FirstName == Fname && customer.LastName == Lname)
                {
                    return customer;
                }
            }
            return null;
            }

    }
}
}

// ToDo : 5/19
// 1. Refactor to add ADO.Net & database
// 2. Add a storage file to store every order and its details
// 3. Add testing 
// 4. change program so it doesnt quit after the order is complete, should go back to login screen

 