namespace _02.CompanyFiles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Wintellect.PowerCollections;

    class Startup
    {
        static OrderedMultiDictionary<decimal, Article> dict = new OrderedMultiDictionary<decimal, Article>(true);
        static void Main()
        {
            GenerateArticles();
            PrintRange(55.3m, 64m);
        }

        public static void PrintRange(decimal start, decimal end)
        {
            var result = dict.Range(start, true, end, true).Select(x => x.Value).SelectMany(x => x).ToList();
            var builder = new StringBuilder();
            builder.AppendLine(string.Format("Printing products from {0} to {1}:", start, end));
            foreach (var product in result)
            {
                builder.AppendLine(product.ToString());
            }
            Console.WriteLine(builder.ToString());
        }

        public static void GenerateArticles(int count = 50000)
        {
            for (int i = 0; i < count; i++)
            {
                var article = new Article(i, "vendor" + i, "title" + i, i * 0.5m);
                var price = article.Price;
                dict.Add(price, article);
            }
        }
    }
}
