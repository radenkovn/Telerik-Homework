namespace Catalogue
{
    using System;
    using System.Xml;
    using System.Collections.Generic;
    using System.Collections;
    using System.Xml.Linq;
    using System.Linq;
    using System.IO;
    using System.Text;
    using System.Xml.Xsl;
    using System.Xml.Schema;
    class Program
    {
        static void Main(string[] args)
        {


            ////Task 2
            //ExtractArtistsAndAlbumCount();

            ////Task 3
            //ExtractArtisatsAndAlbumCountXPath();

            ////Task 4
            ////DeleteAllAboveTwenty();

            ////Task 5
            //ExtractAllSongsTitles();

            ////Task 6
            //ExtractAllSongsTitlesLINQ();

            ////Task 7
            //CreatePersonXml();

            ////Task 8
            //CreateAlbumXml();

            ////Task 9
            //TraverseDirectory(@"../../");

            ////Task 10
            //TraverseDirectoryXelement(@"../../");

            ////Task 11
            //ExtractFiveYearsAgo();

            ////task 12
            //ExtractFiveYearsAgoLINQ();

            ////Task 13
            ////Task 14 
            //TransformXML();

            //Task 16
            ValidateXmlvsXsd();


        }
        static void ValidateXmlvsXsd()
        {
            var xsdFile = "../../Database/AudioCatalog.xsd";
            var validXml = "../../Database/AudioCatalog.xml";
            var invalidXml = "../../Database/InvalidCatalog.xml";
            Console.WriteLine("Valid xml test\n\n");
            ValidateSchema(xsdFile, validXml);
            Console.WriteLine("Invalid xml test: \n");
            ValidateSchema(xsdFile, invalidXml);
        }
        static void ValidateSchema(string xsdName, string xmlName)
        {
            XmlReaderSettings albumSettings = new XmlReaderSettings();
            albumSettings.Schemas.Add("http://www.albums.com/albums", xsdName);
            albumSettings.ValidationType = ValidationType.Schema;
            albumSettings.ValidationEventHandler += new ValidationEventHandler(booksSettingsValidationEventHandler);

            XmlReader books = XmlReader.Create(xmlName, albumSettings);

            while (books.Read()) { }
        }

        static void booksSettingsValidationEventHandler(object sender, ValidationEventArgs e)
        {
            if (e.Severity == XmlSeverityType.Warning)
            {
                Console.Write("WARNING: ");
                Console.WriteLine(e.Message);
            }
            else if (e.Severity == XmlSeverityType.Error)
            {
                Console.Write("ERROR: ");
                Console.WriteLine(e.Message);
            }
        }
        static void TransformXML()
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("../../Database/catalogueTransformer.xsl");
            xslt.Transform("../../Database/AudioCatalog.xml", "../../Database/catalog.html");
        }

        static void ExtractFiveYearsAgoLINQ()
        {
            Console.WriteLine("Prices of Old songs with LINQ:\n");
            XDocument xmlDoc = XDocument.Load("../../Database/AudioCatalog.xml");
            var currentYear = DateTime.Now.Year;
            var albums =
                from album in xmlDoc.Descendants("album")
                where int.Parse(album.Element("year").Value) < currentYear - 5
                select new
                {
                    price = album.Element("price").Value
                };
            foreach (var album in albums)
            {
                Console.WriteLine(album.price);
            }
            Console.WriteLine();
        }
        static void ExtractFiveYearsAgo()
        {
            XmlDocument catalogue = new XmlDocument();
            catalogue.Load("../../Database/AudioCatalog.xml");
            string xPathQuery = "/albums/album";

            XmlNodeList albums = catalogue.SelectNodes(xPathQuery);
            var year = "year";
            List<double> prices = new List<double>();
            var price = "price";

            foreach (XmlNode album in albums)
            {
                int currentYear = DateTime.Now.Year - 5;
                var albumYear = int.Parse(album[year].InnerText);
                if (albumYear < currentYear)
                {
                    var currentPrice = double.Parse(album[price].InnerText);
                    prices.Add(currentPrice);
                }
            }
            Console.WriteLine("Prices of all albums which are older than 5 years\n");
            Console.WriteLine(String.Join("\n", prices.ToArray()));
            Console.WriteLine();

        }
        private static void TraverseDirectoryXelement(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            XElement directory = CreateXML(dir);
            directory.Save("../../Database/directoriesXpath.xml");
        }

        static List<String> DirSearch(string sDir)
        {
            List<String> files = new List<String>();
            foreach (string f in Directory.GetFiles(sDir))
            {
                files.Add(f);
            }
            foreach (string d in Directory.GetDirectories(sDir))
            {
                files.AddRange(DirSearch(d));
            }
            return files;
        }
        //Taken from Internet
        private static XElement CreateXML(DirectoryInfo dir)
        {
            var xmlInfo = new XElement("projectfiles");
            //get all the files first
            foreach (var file in dir.GetFiles())
            {
                xmlInfo.Add(new XElement("file", new XAttribute("name", file.Name)));
            }
            //get subdirectories
            foreach (var subDir in dir.GetDirectories())
            {
                xmlInfo.Add(CreateSubdirectoryXML(subDir));
            }
            return xmlInfo;
        }

        private static XElement CreateSubdirectoryXML(DirectoryInfo dir)
        {
            //get directories
            var xmlInfo = new XElement("dir", new XAttribute("name", dir.Name));
            //get all the files first
            foreach (var file in dir.GetFiles())
            {
                xmlInfo.Add(new XElement("file", new XAttribute("name", file.Name)));
            }
            //get subdirectories
            foreach (var subDir in dir.GetDirectories())
            {
                xmlInfo.Add(CreateSubdirectoryXML(subDir));
            }
            return xmlInfo;
        }
        static void TraverseDirectory(string path)
        {
            var files = DirSearch(path);
            Console.WriteLine(string.Join("\n ", files.ToArray()));
        }
        static void CreateAlbumXml()
        {
            var albumName = "name";
            var artistName = "artist";
            Dictionary<string, string> albums = new Dictionary<string, string>();

            using (XmlReader catalogueReader = XmlReader.Create("../../Database/AudioCatalog.xml"))
            {
                string currentAlbum = "";
                string currentArtist = "";
                while (catalogueReader.Read())
                {
                    if ((catalogueReader.NodeType == XmlNodeType.Element) && (catalogueReader.Name == albumName))
                    {
                        currentAlbum = (catalogueReader.ReadElementContentAsString());
                    }
                    if ((catalogueReader.NodeType == XmlNodeType.Element) && (catalogueReader.Name == artistName))
                    {
                        currentArtist = (catalogueReader.ReadElementContentAsString());
                        if (!albums.ContainsKey(currentAlbum))
                        {
                            albums.Add(currentAlbum, currentArtist);
                        }
                    }
                }
            }

            string fileName = "../../Database/Album.xml";
            Encoding encoding = Encoding.UTF8;
            using (XmlTextWriter writer = new XmlTextWriter(fileName, encoding))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;
                writer.WriteStartDocument();
                writer.WriteStartElement("albums");
                foreach (var album in albums)
                {
                    WriteAlbum(writer, album.Key, album.Value);
                }
                writer.WriteEndDocument();
            }
            Console.WriteLine("Album.xml ready!\n");
        }
        private static void WriteAlbum(XmlWriter writer, string name, string artist)
        {
            writer.WriteStartElement("album");
            writer.WriteElementString("name", name);
            writer.WriteElementString("artist", artist);
            writer.WriteEndElement();
        }
        static void CreatePersonXml()
        {
            List<string> person = new List<string>();
            StreamReader reader = new StreamReader("../../Database/PersonData.txt");
            using (reader)
            {
                string currentLine = reader.ReadLine();
                person.Add(currentLine);
                while (currentLine != null)
                {
                    currentLine = reader.ReadLine();
                    person.Add(currentLine);
                }
            }
            XElement personXml = new XElement("person",
                new XElement("name", person[0]),
                new XElement("address"), person[1],
                new XElement("phone", person[2])
                );
            personXml.Save("../../Database/PersonData.xml");
            Console.WriteLine("\nPerson Data saved!\n");
        }
        static void ExtractAllSongsTitlesLINQ()
        {
            Console.WriteLine("Song Titles using XDocument:\n");
            XDocument xmlDoc = XDocument.Load("../../Database/AudioCatalog.xml");
            var songs =
                from song in xmlDoc.Descendants("song")
                select new
                {
                    Title = song.Element("title").Value
                };
            foreach (var song in songs)
            {
                Console.WriteLine(song.Title);
            }
            Console.WriteLine();
        }

        static void ExtractAllSongsTitles()
        {
            var songTitles = new HashSet<string>();
            var searchAttribute = "title";

            Console.WriteLine("Song Titles using XmlReader: \n");
            using (XmlReader catalogueReader = XmlReader.Create("../../Database/AudioCatalog.xml"))
            {
                while (catalogueReader.Read())
                {
                    if ((catalogueReader.NodeType == XmlNodeType.Element) && (catalogueReader.Name == searchAttribute))
                    {
                        songTitles.Add(catalogueReader.ReadElementContentAsString());
                    }
                }
            }
            Console.WriteLine(string.Join("\n", songTitles));
            Console.WriteLine();
        }
        static void DeleteAllAboveTwenty()
        {
            XmlDocument catalogue = new XmlDocument();
            catalogue.Load("../../Database/AudioCatalog.xml");
            string xPathQuery = "/albums/album";

            XmlNodeList albums = catalogue.SelectNodes(xPathQuery);
            var searchAttribute = "price";

            foreach (XmlNode album in albums)
            {
                var currentPrice = int.Parse(album[searchAttribute].InnerText);
                if (currentPrice > 20)
                {
                    album.RemoveAll();
                    continue;
                }
            }

            catalogue.Save("../../Database/AudioCatalog.xml");

        }

        static void ExtractArtisatsAndAlbumCountXPath()
        {
            XmlDocument catalogue = new XmlDocument();
            catalogue.Load("../../Database/AudioCatalog.xml");
            string xPathQuery = "/albums/album";

            XmlNodeList albums = catalogue.SelectNodes(xPathQuery);
            var artists = new Hashtable();
            var searchAttribute = "artist";

            foreach (XmlNode album in albums)
            {
                var currentArtist = album[searchAttribute].InnerText;

                if (artists.ContainsKey(currentArtist))
                {
                    var currentAlbumsCount = (int)artists[currentArtist];
                    artists[currentArtist] = currentAlbumsCount + 1;
                }
                else
                {
                    artists.Add(currentArtist, 1);
                }
            }

            Console.WriteLine("XPath");
            foreach (DictionaryEntry entry in artists)
            {
                Console.WriteLine("{0}, {1}", entry.Key, entry.Value);
            }
            Console.WriteLine();
        }

        static void ExtractArtistsAndAlbumCount()
        {
            XmlDocument catalogue = new XmlDocument();
            catalogue.Load("../../Database/AudioCatalog.xml");
            XmlNode albumsNode = catalogue.DocumentElement;

            var artists = new Hashtable();
            var searchAttribute = "artist";

            foreach (XmlNode album in albumsNode.ChildNodes)
            {
                var currentArtist = album[searchAttribute].InnerText;

                if (artists.ContainsKey(currentArtist))
                {
                    var currentAlbumsCount = (int)artists[currentArtist];
                    artists[currentArtist] = currentAlbumsCount + 1;
                }
                else
                {
                    artists.Add(currentArtist, 1);
                }
            }

            Console.WriteLine("Dom Parser");
            foreach (DictionaryEntry entry in artists)
            {
                Console.WriteLine("{0}, {1}", entry.Key, entry.Value);
            }
            Console.WriteLine();
        }
    }
}
