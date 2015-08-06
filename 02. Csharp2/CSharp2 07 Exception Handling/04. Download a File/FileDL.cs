//Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.



using System;
using System.Net;
class FileDL
{
    static void Main()
    {
        try
        {
            string remoteUri = "http://telerikacademy.com/Content/Images/news-img01.png";
            string fileName = "..\\..\\..\\Downloads\\image.png", myStringWebResource = null;

            using (WebClient myWebClient = new WebClient())
            {
                myStringWebResource = remoteUri;
                myWebClient.DownloadFile(myStringWebResource, fileName);
            }
            Console.WriteLine("Image successfully downloaded.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Error: The download address is empty.");
        }
        catch (WebException)
        {
            Console.WriteLine("Error: You have no internet, or one of the addresses is invalid");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Error: This method has been canceled somewhere else in the program");
        }
    }
}

