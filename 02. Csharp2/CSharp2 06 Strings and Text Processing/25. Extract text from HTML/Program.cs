//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

using System;
using System.Text;
class Program
{
    static void Main()
    {
        string input = "<html>" +
                       "<head><title>News</title></head>" +
                       "<body><p><a href=\"http://academy.telerik.com\">Telerik" +
                       "Academy</a>aims to provide free real-world practical" +
                       "training for young people who want to turn into" +
                       "skilful .NET software engineers.</p></body>" +
                       "</html>";
        string title = string.Empty;
        if (input.IndexOf("<title>") > 0)
        {
            title += input.Substring(input.IndexOf("<title>") + 7, (input.IndexOf("</title>") - input.IndexOf("<title>") - 7));

        }
        StringBuilder finalText = new StringBuilder();
        if (input.IndexOf("<body>") > 0)
        {
            if (input.IndexOf("<p>") > 0)
            {
                if (input.IndexOf("<a href=") > 0) 
                {
                    int indexStart = input.IndexOf("\">", input.IndexOf("<a href="));
                    int indexEnd = input.IndexOf("</a>", input.IndexOf("<a href="));
                    finalText.Append(input.Substring(indexStart + 2, indexEnd - indexStart - 2));
                    finalText.Append(" ");
                    int indexStarter = input.IndexOf("</a>", input.IndexOf("<a href="));
                    int indexEnder = input.IndexOf("</p>", input.IndexOf("<a href="));
                    finalText.Append(input.Substring(indexStarter + 4, indexEnder - indexStarter - 4));
                }
                else
                {
                    int indexStart = input.IndexOf("<p>");
                    int indexEnd = input.IndexOf("</p>");
                    finalText.Append(input.Substring(indexStart + 3, indexEnd - indexStart - 2));
                }
            }
            else
            {
                int indexStart = input.IndexOf("<body>");
                int indexEnd = input.IndexOf("</body>");
                finalText.Append(input.Substring(indexStart + 6, indexEnd - indexStart - 6));
            }
        }
        Console.WriteLine("Title: {0}", title);
        Console.WriteLine("Text: {0}", finalText);
    }
}

