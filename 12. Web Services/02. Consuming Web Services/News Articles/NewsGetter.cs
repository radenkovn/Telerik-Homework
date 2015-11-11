namespace News_Articles
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Xml.Linq;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class News
    {
        //Feedzilla was not working, so i used google's news API
        public static List<NewsItem> GetNewsContent(string newsParameter)
        {
            List<NewsItem> result = new List<NewsItem>();

            var request = WebRequest.Create("http://news.google.com/news?q=" + newsParameter + "&output=rss") as HttpWebRequest;

            request.Method = "GET";

            var response = request.GetResponse();
            var responseReader = new StreamReader(response.GetResponseStream());

            var doc = XDocument.Load(responseReader);
            var json = JsonConvert.SerializeXNode(doc, Newtonsoft.Json.Formatting.Indented);
            var jsonObject = JObject.Parse(json);

            result = jsonObject["rss"]["channel"]["item"]
                .Select(x => new NewsItem
                {
                    Title = (string)x["title"],
                    Date = (string)x["pubDate"]
                })
                .ToList();

            return result;
        }
    }
}
