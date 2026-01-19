using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp
{
    // Define some data structures to work with
    public class Order
    {
        public int OrderId { get; set; }
        public decimal Amount { get; set; }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();
    }

    /// <summary>
    /// This class demonstrates LINQ for querying collections,
    /// from simple to more complex scenarios relevant for large datasets.
    /// </summary>
    public static class LINQDemo
    {
        private static List<Customer> customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "Alice", City = "New York", Age = 28, Orders = new List<Order> { new Order { OrderId = 1, Amount = 150.50m }, new Order { OrderId = 2, Amount = 75.20m } } },
            new Customer { Id = 2, Name = "Bob", City = "Los Angeles", Age = 35, Orders = new List<Order> { new Order { OrderId = 3, Amount = 200.00m } } },
            new Customer { Id = 3, Name = "Charlie", City = "New York", Age = 28, Orders = new List<Order> { new Order { OrderId = 4, Amount = 50.00m }, new Order { OrderId = 5, Amount = 60.50m } } },
            new Customer { Id = 4, Name = "David", City = "Chicago", Age = 42, Orders = new List<Order>() },
            new Customer { Id = 5, Name = "Eve", City = "Los Angeles", Age = 35, Orders = new List<Order> { new Order { OrderId = 6, Amount = 300.00m } } }
        };

        public static void Show()
        {
            Console.WriteLine("\n--- LINQ Demo ---");
            LogOriginalCustomerData();
            SimpleQueries();
            ComplexQueries();
        }

        public static void LogOriginalCustomerData()
        {
            Console.WriteLine("\n--- Original Customer Data ---");
            foreach (var customer in customers)
            {
                Console.Write($"- Id: {customer.Id}, Name: {customer.Name}, City: {customer.City}, Age: {customer.Age}");
                if (customer.Orders.Any())
                {
                    Console.Write(", Orders: ");
                    foreach (var order in customer.Orders)
                    {
                        Console.Write($"[Id: {order.OrderId}, Amount: ${order.Amount}] ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void SimpleQueries()
        {
            Console.WriteLine("\n--- Simple LINQ Queries ---");

            // 1. Filtering (Method Syntax)
            var nyCustomers = customers.Where(c => c.City == "New York");
            Console.WriteLine("\nCustomers from New York:");
            foreach (var c in nyCustomers) Console.WriteLine($"- {c.Name}");

            // 2. Ordering (Query Syntax)
            var orderedCustomers = from c in customers
                                   orderby c.Name
                                   select c;
            Console.WriteLine("\nCustomers ordered by name:");
            foreach (var c in orderedCustomers) Console.WriteLine($"- {c.Name}");

            // 3. Projection (Method Syntax)
            var customerNames = customers.Select(c => c.Name);
            Console.WriteLine("\nAll customer names:");
            foreach (var name in customerNames) Console.WriteLine($"- {name}");
        }

        public static void ComplexQueries()
        {
            Console.WriteLine("\n--- Complex LINQ Queries for Large Datasets ---");
            Console.WriteLine("These examples show techniques that are efficient with large datasets, especially when using LINQ to SQL or Entity Framework, as they translate to efficient SQL queries.");

            // 1. Grouping
            var customersByCity = from c in customers
                                  group c by c.City;

            Console.WriteLine("\nCustomers grouped by city:");
            foreach (var group in customersByCity)
            {
                Console.WriteLine($"- {group.Key}: {group.Count()} customers");
                foreach (var customer in group)
                {
                    Console.WriteLine($"  - {customer.Name}");
                }
            }

            // 2. Aggregation
            var averageAge = customers.Average(c => c.Age);
            Console.WriteLine($"\nAverage customer age: {averageAge:F2}");

            // 3. Complex Projection (Joining with related data)
            var customerOrderTotals = customers.Select(c => new
            {
                CustomerName = c.Name,
                TotalOrderAmount = c.Orders.Sum(o => o.Amount)
            });

            Console.WriteLine("\nTotal order amount per customer:");
            foreach (var item in customerOrderTotals)
            {
                Console.WriteLine($"- {item.CustomerName}: ${item.TotalOrderAmount}");
            }

            // 4. Paging with Skip and Take
            int pageSize = 2;
            int pageNumber = 2;
            var pagedCustomers = customers.Skip((pageNumber - 1) * pageSize).Take(pageSize);

            Console.WriteLine($"\nCustomers on page {pageNumber} (Page size: {pageSize}):");
            foreach (var c in pagedCustomers)
            {
                Console.WriteLine($"- {c.Name}");
            }
        }
    }
}
