//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
//input
//<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>

using System;
using System.Text;
class ReplaceTags
{
    static void Main()
    {
        Console.WriteLine("Enter your text in HTML format");
        string input = Console.ReadLine();
        TagReplacer(input);
    }
    private static void TagReplacer(string text)
    {

        StringBuilder builder = new StringBuilder(text);

        builder.Replace("<a href=\"", "[URL=");
        builder.Replace("\">", "]");
        builder.Replace("</a>", "[/URL]");
        Console.WriteLine(builder);
    }
}

