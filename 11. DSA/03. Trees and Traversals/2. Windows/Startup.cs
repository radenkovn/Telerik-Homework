namespace _2.Windows
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;
    using System.Text.RegularExpressions;

    public class Startup
    {
        public static void Main()
        {
            FindExes(@"C:\WINDOWS\");
        }

        public static void FindExes(string path)
        {
            try
            {
                var files = Directory.GetFiles(path);
                string pattern = @"^.*\.(exe)$";

                foreach (var file in files)
                {
                    if (Regex.IsMatch(file, pattern))
                    {
                        Console.WriteLine(file);
                    }
                }
                var directories = Directory.GetDirectories(path);
                foreach (var directory in directories)
                {
                    FindExes(directory);
                }
            }
            catch
            {
                Console.WriteLine("Error - Probably unauthorized");
            }
        }
    }
}
