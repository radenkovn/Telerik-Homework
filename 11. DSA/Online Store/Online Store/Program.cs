using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace Online_Store
{
    public class Product
    {
        private string savedString;
        public Product(string name, decimal price, string producer)
        {
            this.Name = name;
            this.Price = price;
            this.Producer = producer;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Producer { get; set; }

        public override string ToString()
        {
            if (savedString != string.Empty)
            {
                savedString = string.Format("{{{0};{1};{2:0.00}}}", this.Name, this.Producer, this.Price);
            }
            return savedString;
        }

    }

    class Program
    {

        static Dictionary<string, List<Product>> nameProducers = new Dictionary<string, List<Product>>();
        static Dictionary<string, List<Product>> names = new Dictionary<string, List<Product>>();
        static Dictionary<decimal, List<Product>> prices = new Dictionary<decimal, List<Product>>();
        static Dictionary<string, List<Product>> producers = new Dictionary<string, List<Product>>();
        static StringBuilder builder = new StringBuilder();
        const string NoProductsFound = "No products found";

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var whiteSpace = input.IndexOf(' ');
                var command = input.Substring(0, whiteSpace);
                input = input.Substring(whiteSpace + 1);
                var arguments = input.Split(';');

                if (command == "AddProduct")
                {
                    AddProducts(arguments);
                }
                else if (command == "DeleteProducts")
                {
                    DeleteProducts(arguments);
                }
                else if (command == "FindProductsByName")
                {
                    FindProductsByName(arguments);
                }
                else if (command == "FindProductsByProducer")
                {
                    FindProductsByProducer(arguments);
                }
                else if (command == "FindProductsByPriceRange")
                {
                    FindProductsByPriceRange(arguments);
                }
            }
            Console.WriteLine(builder.ToString());
        }

        static void FindProductsByPriceRange(string[] arguments)
        {
            var fromPrice = decimal.Parse(arguments[0]);
            var toPrice = decimal.Parse(arguments[1]);
            var foundProducts = prices.Where(x => x.Key >= fromPrice && x.Key <= toPrice).SelectMany(x=>x.Value).ToList();

            PrintList(foundProducts);
        }

        static void FindProductsByProducer(string[] arguments)
        {
            var producer = arguments[0];
            //var foundProducts = new List<Product>();
            if (producers.ContainsKey(producer))
            {
                PrintList(producers[producer]);
            }
            else
            {
                builder.AppendLine(NoProductsFound);
            }
        }

        static void FindProductsByName(string[] arguments)
        {
            var name = arguments[0];
            //var foundProducts = new List<Product>();
            if (names.ContainsKey(name))
            {
                PrintList(names[name]);
            }
            else
            {
                builder.AppendLine(NoProductsFound);
            }
        }

        static void DeleteProducts(string[] arguments)
        {
            var productsToDelete = new List<Product>();
            if (arguments.Length == 1)
            {
                var producer = arguments[0];
                if (producers.ContainsKey(producer))
                {
                    productsToDelete = producers[producer].ToList();
                    foreach (var pr in productsToDelete)
                    {
                        var name = pr.Name;
                        var price = pr.Price;
                        var nameProducer = name + producer;

                        names[name].Remove(pr);
                        prices[price].Remove(pr);
                        nameProducers[nameProducer].Remove(pr);
                    }
                    producers.Remove(producer);
                }
            }
            else
            {
                var name = arguments[0];
                var producer = arguments[1];
                var nameProducer = name + producer;

                if (nameProducers.ContainsKey(nameProducer))
                {
                    productsToDelete = nameProducers[nameProducer].ToList();

                    foreach (var pr in productsToDelete)
                    {
                        var price = pr.Price;

                        names[name].Remove(pr);
                        prices[price].Remove(pr);
                        producers[producer].Remove(pr);
                    }
                    nameProducers.Remove(nameProducer);
                }
            }

            if (productsToDelete.Count > 0)
            {
                builder.AppendLine(productsToDelete.Count + " products deleted");
            }
            else
            {
                builder.AppendLine(NoProductsFound);
            }
        }

        static void PrintList(ICollection<Product> products)
        {
            products = products.OrderBy(x => x.ToString()).ToList();
            if (products.Count > 0)
            {
                foreach (var pr in products)
                {
                    builder.AppendLine(pr.ToString());
                }
            }
            else
            {
                builder.AppendLine(NoProductsFound);
            }
        }

        static void AddProducts(string[] arguments)
        {
            var name = arguments[0];
            var price = decimal.Parse(arguments[1]);
            var producer = arguments[2];
            var product = new Product(name, price, producer);
            builder.AppendLine("Product added");
            var nameProducerKey = name + producer;

            if (!nameProducers.ContainsKey(nameProducerKey))
            {
                nameProducers[nameProducerKey] = new List<Product>();
            }

            nameProducers[nameProducerKey].Add(product);

            if (!names.ContainsKey(name))
            {
                names[name] = new List<Product>();
            }

            names[name].Add(product);

            if (!prices.ContainsKey(price))
            {
                prices[price] = new List<Product>();
            }

            prices[price].Add(product);

            if (!producers.ContainsKey(producer))
            {
                producers[producer] = new List<Product>();
            }

            producers[producer].Add(product);

        }
    }
}
