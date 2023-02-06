using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AggregateOperator
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public Order[] Orders { get; set; }
        public override string ToString() =>
            $"{CustomerID} {CompanyName}\n{Address}\n{City}, {Region} {PostalCode} {Country}\n{Phone}";
    }

    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public decimal Total { get; set; }
        public override string ToString() => $"{OrderID}: {OrderDate:d} for {Total:C2}";
    }
    public static class Customers
    {
        public static List<Customer> CustomerList { get; } =
            new List<Customer>
            {
                new Customer
                {
                    CustomerID = 1,
                    Address = "Dhaka",
                    City = "Dhaka",
                    CompanyName = "BS",
                    Country = "BANGLASESH",
                    Phone = "017",
                    PostalCode = "0002",
                    Region = "BD",
                    Orders = new[] { 
                        new Order { Total = 100, OrderID = 0, OrderDate = DateTime.Now },
                        new Order { Total = 200, OrderID = 1, OrderDate = DateTime.Now.AddDays(1) },
                        new Order { Total = 300, OrderID = 2, OrderDate = DateTime.Now.AddDays(2) }
                    },
                },
                new Customer
                {
                    CustomerID = 2,
                    Address = "Dhaka",
                    City = "Dhaka",
                    CompanyName = "BS",
                    Country = "BANGLASESH",
                    Phone = "017",
                    PostalCode = "0002",
                    Region = "AU",
                    Orders = new[] {
                        new Order { Total = 100, OrderID = 0, OrderDate = DateTime.Now },
                        new Order { Total = 200, OrderID = 1, OrderDate = DateTime.Now.AddDays(1) },
                        
                    },
                },
                 new Customer
                {
                    CustomerID = 3,
                    Address = "Dhaka",
                    City = "Dhaka",
                    CompanyName = "BS",
                    Country = "BANGLASESH",
                    Phone = "017",
                    PostalCode = "0002",
                    Region = "BD",
                    Orders = new[] {
                        new Order { Total = 100, OrderID = 0, OrderDate = DateTime.Now },
                        new Order { Total = 200, OrderID = 1, OrderDate = DateTime.Now.AddDays(1) },
                        new Order { Total = 300, OrderID = 2, OrderDate = DateTime.Now.AddDays(2) }
                    },
                },
                new Customer
                {
                    CustomerID = 4,
                    Address = "Dhaka",
                    City = "Dhaka",
                    CompanyName = "BS",
                    Country = "BANGLASESH",
                    Phone = "017",
                    PostalCode = "0002",
                    Region = "AU",
                    Orders = new[] {
                        new Order { Total = 100, OrderID = 0, OrderDate = DateTime.Now },
                        new Order { Total = 200, OrderID = 1, OrderDate = DateTime.Now.AddDays(1) },
                        new Order { Total = 100, OrderID = 2, OrderDate = DateTime.Now },
                        new Order { Total = 200, OrderID = 3, OrderDate = DateTime.Now.AddDays(1) },
                        new Order { Total = 300, OrderID = 4, OrderDate = DateTime.Now.AddDays(2) }

                    },
                }
            };
        /*
        public static class Customers
        {
            public static List<Customer> CustomerList { get; } =
                (from e in XDocument.Parse(InputValues.CustomersXml).Root.Elements("customer")
                 select new Customer
                 {
                     CustomerID = (string)e.Element("id"),
                     CompanyName = (string)e.Element("name"),
                     Address = (string)e.Element("address"),
                     City = (string)e.Element("city"),
                     Region = (string)e.Element("region"),
                     PostalCode = (string)e.Element("postalcode"),
                     Country = (string)e.Element("country"),
                     Phone = (string)e.Element("phone"),
                     Orders = (
                        from o in e.Elements("orders").Elements("order")
                        select new Order
                        {
                            OrderID = (int)o.Element("id"),
                            OrderDate = (DateTime)o.Element("orderdate"),
                            Total = (decimal)o.Element("total")
                        }).ToArray()
                 }).ToList();
        }*/
    }
}
