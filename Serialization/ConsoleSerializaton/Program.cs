using ConsoleSerializaton.DAL;
using ConsoleSerializaton.Models;
using System.Collections.Generic;

namespace ConsoleSerializaton
{
    internal class Program
    {
        static readonly RepositoryXml repXml = new RepositoryXml();
        static readonly RepositoryJson repJson = new RepositoryJson();

        static void Main(string[] args)
        {
            var p1 = new Product { Id = 1, Price = 43.56, Title = "Best" };
            var p2 = new Product { Id = 2, Price = 18.9, Title = "Good" };

            var o1 = new Order { Id = 1, Status = true, Products = new List<Product> { p1, p2 } };
            var o2 = new Order { Id = 2, Status = false, Products = new List<Product> { p1, p2 } };

            var c1 = new Customer { Id = 1, Name = "First", Orders = new List<Order> { o1, o2 } };
            var c2 = new Customer { Id = 1, Name = "Second", Orders = new List<Order> { o1, o2 } };

            var customers = new List<Customer> { c1, c2 };

            repXml.Save(customers);
            var customersXml = repXml.Load<List<Customer>>();

            repJson.Save(customers);
            var customersJson = repJson.Load<List<Customer>>();
        }
    }
}