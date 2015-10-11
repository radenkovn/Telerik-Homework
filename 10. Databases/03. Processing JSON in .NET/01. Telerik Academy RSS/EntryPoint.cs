namespace Telerik_Academy_RSS
{
    using System;
    using System.Net;
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using System.IO;
    using System.Xml.Linq;
    using Newtonsoft.Json.Linq;
    using System.Web.UI;
    using System.Text;
    public class EntryPoint
    {
        static void Main()
        {
            //GetFeed();

            var path = "..\\..\\Database/TelerikAcademy.xml";
            var doc = XDocument.Load(path);
            var json = JsonConvert.SerializeXNode(doc, Newtonsoft.Json.Formatting.Indented);
            //XDocument xml = JsonConvert.DeserializeXNode(json);
            //Console.WriteLine(json.ToString());


            var jsonObject = JObject.Parse(json);
            PrintTitles(jsonObject);
            CreateHTMLFile(jsonObject);



        }
        static void CreateHTMLFile(JObject jsonObject)
        {
            var videos = GetVideos(jsonObject);
            StringWriter stringWriter = new StringWriter();

            using (HtmlTextWriter writer = new HtmlTextWriter(stringWriter))
            {
                foreach (var video in videos)
                {
                    var title = video.Title;
                    var url = video.URL;
                    writer.RenderBeginTag(HtmlTextWriterTag.Div);
                    writer.RenderBeginTag(HtmlTextWriterTag.H3);
                    writer.Write(title);
                    writer.RenderEndTag();
                    writer.AddAttribute(HtmlTextWriterAttribute.Href, url);
                    writer.RenderBeginTag(HtmlTextWriterTag.Iframe);
                    writer.RenderEndTag();
                    writer.RenderEndTag();
                }
                Console.WriteLine("I tried, didn't work ;(");
            }
            var fullHtml = stringWriter.ToString();
            StreamWriter textWriter = new StreamWriter("..\\..\\Database/Telerik.html");
            using (textWriter)
            {
                textWriter.Write(fullHtml);
            }
        }
        static void PrintTitles(JObject jsonObject)
        {
            Console.WriteLine("Video Titles: \n");
            var titles = jsonObject["feed"]["entry"].Select(x => x["title"]);
            foreach (var item in titles)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        static List<Video> GetVideos(JObject jsonObject)
        {
            var titles = jsonObject["feed"]["entry"].Select(x => x["title"]).ToList();
            var urls = jsonObject["feed"]["entry"].Select(x => x["link"]["@href"]).ToList();
            var videos = new List<Video>();
            var count = titles.Count;
            for (int i = 0; i < count; i++)
            {
                videos.Add(new Video(titles[i].ToString(), urls[i].ToString()));
            }
            return videos;
        }
        public class Video
        {
            public Video(string title, string url)
            {
                this.Title = title;
                this.URL = url;
            }
            public string Title { get; set; }
            public string URL { get; set; }
        }
        static void GetFeed()
        {
            string URL = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
            string fileName = "../../Database/TelerikAcademy.xml";
            WebClient myWebClient = new WebClient();
            myWebClient.DownloadFile(URL, fileName);
        }
    }
}
