namespace _01.Northwind_tasks
{
    using System;
    using System.Linq;
    public class CustomersDAO
    {
        public static void InsertCustomers(string customerID, string companyName, string contactName = null, string address = null, string city = null, string region = null, string postalCode = null, string country = null, string phone = null, string fax = null)
        {
            NorthwindEntities db = new NorthwindEntities();
            Customer newCustomer = new Customer
            {
                CustomerID = customerID,
                CompanyName = companyName,
                ContactName = contactName,
                Address = address,
                City = city,
                Region = region,
                PostalCode = postalCode,
                Country = country,
                Phone = phone,
                Fax = fax
            };
            if (GetCustomerById(db, customerID) != null)
            {
                return;
            }
            db.Customers.Add(newCustomer);
            db.SaveChanges();
        }

        public static void PrintCustomers(string customerID = null)
        {
            NorthwindEntities northwindEntities = new NorthwindEntities();
            if (customerID == null)
            {
                var customers = northwindEntities.Customers.Select(c => new { CustomerID = c.CustomerID, CompanyName = c.CompanyName }).ToList();
                foreach (var customer in customers)
                {
                    PrintCustomer(customer.CustomerID, customer.CompanyName);
                }
            }
            else
            {
                var customer = northwindEntities.Customers.FirstOrDefault(c => c.CustomerID == customerID);
                if (customer == null)
                {
                    return;
                }
                else
                {
                    PrintCustomer(customer.CustomerID, customer.CompanyName);
                }
            }
            Console.WriteLine();
        }

        private static void PrintCustomer(string customerID, string companyName)
        {
            Console.WriteLine("{0}  -  {1}", customerID, companyName);
        }

        public static void ModifyCustomer(string customerID, string newCompanyName)
        {
            NorthwindEntities northwindEntities = new NorthwindEntities();
            Customer customer = GetCustomerById(northwindEntities, customerID);
            if (customer == null)
            {
                return;
            }
            customer.CompanyName = newCompanyName;
            northwindEntities.SaveChanges();
            Console.WriteLine("{0} modified!", customerID);

        }

        public static void DeleteCustomer(string customerId)
        {
            NorthwindEntities northwindEntities = new NorthwindEntities();
            Customer customer = GetCustomerById(northwindEntities, customerId);
            if (customer == null)
            {
                return;
            }
            northwindEntities.Customers.Remove(customer);
            northwindEntities.SaveChanges();
            Console.WriteLine("{0} deleted!", customerId);
        }

        private static Customer GetCustomerById(NorthwindEntities northwindEntities, string customerID)
        {
            Customer customer = northwindEntities.Customers.FirstOrDefault(p => p.CustomerID == customerID);
            if (customer == null)
            {
                Console.WriteLine("No customer with the id {0} found", customerID);
            }
            return customer;
        }

        public static void FindAllCanadaNinetySeven()
        {
            NorthwindEntities db = new NorthwindEntities();
            var customers = db.Orders
                .Select(o => new
                {
                    o.OrderDate,
                    o.ShipCountry,
                    o.Customer.CustomerID,
                    o.Customer.CompanyName
                })
                .Where(o => (o.OrderDate >= new DateTime(1997, 1, 1) && o.OrderDate <= new DateTime(1997, 12, 31)) && o.ShipCountry == "Canada")
                .Select(o => new
                {
                    CustomerID = o.CustomerID,
                    CompanyName = o.CompanyName
                })
                .OrderBy(c => c.CustomerID)
                .Distinct()
                .ToList();
            foreach (var customer in customers)
            {
                PrintCustomer(customer.CustomerID, customer.CompanyName);
            }
            Console.WriteLine();
        }

        // SELECT DISTINCT c.CustomerID, c.CompanyName FROM Orders o JOIN Customers c ON o.CustomerID= c.CustomerID WHERE (o.OrderDate BETWEEN '1997/01/01'AND '1997/12/31') AND (o.ShipCountry = 'Canada')
        public static void FindAllCanadaNinetySevenNative()
        {
            NorthwindEntities db = new NorthwindEntities();
            //var customers = (from o in db.Orders
            //                 join c in db.Customers on o.CustomerID equals c.CustomerID
            //                 where (o.OrderDate >= new DateTime(1997, 1, 1) && o.OrderDate <= new DateTime(1997, 12, 31) && (o.ShipCountry == "Canada"))
            //                 orderby c.CustomerID
            //                 select new { c.CustomerID, c.CompanyName })
            //                 .Distinct()
            //                 .ToList();


            string nativeSqlQuery ="SELECT DISTINCT * FROM Orders o JOIN Customers c ON o.CustomerID= c.CustomerID WHERE (o.OrderDate BETWEEN '1997/01/01'AND '1997/12/31') AND (o.ShipCountry = 'Canada')";
            var customers =
                db.Database.SqlQuery<Customer>(nativeSqlQuery);
            foreach (var customer in customers)
            {
                PrintCustomer(customer.CustomerID, customer.CompanyName);
            }
            Console.WriteLine();
        }

        public static void FindAllSales(string region, DateTime startDate, DateTime endDate)
        {
            var db = new NorthwindEntities();
            var orders = db.Orders.Select(o => new { o.OrderID, o.OrderDate, o.ShipRegion }).Where(o => (o.OrderDate >= startDate && o.OrderDate <= endDate && (o.ShipRegion == region))).ToList();
            foreach (var order in orders)
            {
                Console.WriteLine("{0} - {1} - {2}", order.OrderID, order.OrderDate, order.ShipRegion);
            }
        }


        public static void TestSaveChanges()
        {
            NorthwindEntities firstDb = new NorthwindEntities();
            NorthwindEntitiesTwin secondDb = new NorthwindEntitiesTwin();


            Customer customer = firstDb.Customers.FirstOrDefault(p => p.CustomerID == "QUEEN");
            Customer customer2 = secondDb.Customers.FirstOrDefault(p => p.CustomerID == "QUEEN");

            customer.CompanyName = "ZXCVB";
            customer2.CompanyName = "QWERT";

            firstDb.SaveChanges();
            secondDb.SaveChanges();

            Console.WriteLine("ONLY THE SECOND CHANGE REMAINS SAVED");
            Console.WriteLine("Maybe deny access to the second entity?");

        }
    }
}
