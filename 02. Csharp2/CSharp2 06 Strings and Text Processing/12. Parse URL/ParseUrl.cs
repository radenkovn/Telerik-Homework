
//    Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.

//Example:
//URL 	                                                    Information
//http://telerikacademy.com/Courses/Courses/Details/212 	[protocol] = http
//                                                          [server] = telerikacademy.com
//                                                          [resource] = /Courses/Courses/Details/212

using System;
class ParseUrl
{
    static void Main()
    {
        Console.WriteLine("Enter the URL: ");
        string url = Console.ReadLine();
        int colon = url.IndexOf(':');
        string protocol = url.Substring(0, colon);
        int endServer = url.IndexOf('/', colon + 3);
        string server = url.Substring(colon + 3, endServer - colon - 3);
        string resource = url.Substring(endServer);
        Console.WriteLine("The protocol is: {0}", protocol);
        Console.WriteLine("The server   is: {0}", server);
        Console.WriteLine("The resource is: {0}", resource);
    }
}

