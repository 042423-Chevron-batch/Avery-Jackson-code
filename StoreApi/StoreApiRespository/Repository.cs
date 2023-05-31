using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreApiModels;

namespace StoreApiRespository
{
    public class Repository
    {
        //ADO.NET and Database
        private static SqlConnection con { get; set; } = new SqlConnection("Server=tcp:shoe-storeserver.database.windows.net,1433;Initial Catalog=shoe-store;Persist Security Info=False;User ID=shoestore;Password=Fashion11;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");


        public static int Test(string fname, string lname, string email)
        {
            SqlCommand comm = new SqlCommand("INSERT INTO Customer (CustomerId, FirstName, LastName,Email) VALUES ((SELECT MAX(CustomerId) FROM [dbo].[Customer])+1,@fname, @lname,@email);", con);
            comm.Parameters.AddWithValue("@fname", fname);
            comm.Parameters.AddWithValue("@lname", lname);
            comm.Parameters.AddWithValue("@email", email);
            con.Open();
            int res = 0;
            try
            {
                res = comm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                // write this exception to a file, exception.
                Console.WriteLine($"the exception was {ex.Message} - {ex.InnerException}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"the exception was {ex.Message} - {ex.InnerException}");
            }
            Console.WriteLine($"The value is =>{res}.");
            return res;
        }

        // SELECT CustomerId, FirstName, LastName, Email FROM [dbo].[Customer] WHERE FirstName = 'James Alan' AND LastName = 'Moore'; 
        public static Customer Login(string fname, string lname)
        {
            SqlCommand comm = new SqlCommand("SELECT CustomerId, FirstName, LastName, Email FROM [dbo].[Customer] WHERE FirstName = @fname AND LastName = @lname;", con);
            comm.Parameters.AddWithValue("@fname", fname);
            comm.Parameters.AddWithValue("@lname", lname);
            con.Open();
            SqlDataReader ret = comm.ExecuteReader();

            Customer p = new Customer();
            //List<Person> myList = new List<Person>();
            // this while loop will iterate over all the rows in the return. You will need to store all the rows in a List<Person>
            while (ret.Read())
            {
                p = new Customer(ret.GetInt32(0), ret.GetString(1), ret.GetString(2), ret.GetString(3));
                //myList.Add(new Person(ret.GetInt32(0), ret.GetString(1), ret.GetString(2), ret.GetString(3)));
            }
            return p;
        }


        //get all the customers (example)
        public static List<Customer> GetCustomers(string fname, string lname)
        {
            SqlCommand comm = new SqlCommand("SELECT CustomerId, FirstName, LastName, Email FROM [dbo].[Customer];", con);
            con.Open();
            SqlDataReader ret = comm.ExecuteReader();

            List<Customer> myList = new List<Customer>();
            // this while loop will iterate over all the rows in the return. You will need to store all the rows in a List<Person>
            while (ret.Read())
            {
                myList.Add(new Customer(ret.GetInt32(0), ret.GetString(1), ret.GetString(2), ret.GetString(3)));
            }
            return myList;
        }

        public static Customer GetCustomerById(int customerId)
        {
            throw new NotImplementedException();
        }

        public static List<Order> GetOrdersByCustomerId(int customerId)
        {
            throw new NotImplementedException();
        }

        public static List<Order> GetOrdersByStore(string storeName)
        {
            throw new NotImplementedException();
        }

        public static Order GetOrderById(int orderId)
        {
            throw new NotImplementedException();
        }

        public static List<Customer> SearchCustomersByName(string name)
        {
            throw new NotImplementedException();
        }

        public static void AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public static void AddOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public static Store GetStore(string storeName)
        {
            throw new NotImplementedException();
        }
    }
}
    
