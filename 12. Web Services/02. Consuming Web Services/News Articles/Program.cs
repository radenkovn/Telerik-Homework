namespace News_Articles
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var newsList = News.GetNewsContent("Bulgaria");
            foreach (var news in newsList)
            {
                Console.WriteLine(news.Title);
                Console.WriteLine(news.Date);
                Console.WriteLine();
            }
        }
    }
}
