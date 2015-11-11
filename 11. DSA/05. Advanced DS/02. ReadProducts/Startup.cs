namespace _02.ReadProducts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Wintellect.PowerCollections;

    public class Startup
    {
        public static void Main()
        {
            var products = new OrderedBag<Product>();

            GenerateProducts(products);
            PrintTwenty(products, 5000, 20304);
            PrintTwenty(products, 20, 30);
            PrintTwenty(products, 20, 400);
            PrintTwenty(products, 3, 500);
        }

        public static void GenerateProducts(OrderedBag<Product> products)
        {
            for (int i = 0; i < 500000; i++)
            {
                var productToAdd = new Product("Product " + i, i * 2);
                products.Add(productToAdd);
            }
        }

        public static void PrintTwenty(OrderedBag<Product> products, int a, int b)
        {
            var minProduct = new Product("", a);
            var maxProduct = new Product("", b);

            var productsToPrint = products.Range(minProduct, true, maxProduct, true).Take(20).ToList();

            if (productsToPrint.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Printing {2} products between {0} and {1}", a, b, productsToPrint.Count);
                Console.WriteLine();
            }

            foreach (var item in productsToPrint)
            {
                Console.WriteLine("Name - {0:10}, Price - {1:10}", item.Name, item.Price.ToString());
            }
        }
    }
}
