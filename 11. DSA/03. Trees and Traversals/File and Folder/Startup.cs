namespace File_and_Folder
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using File_and_Folder.Classes;


    public class Startup
    {
        public static void Main()
        {
            //Put any directory in the constructor I suggest using other drives than C or non-system folders, because you might get an unauthorized exception
            var folder = new MyFolder("D:\\Program Files (x86)", "Program Files");

            //Put the name of the subfolder
            var subFolder = folder.FindSubFolder("Microsoft Visual Studio 12.0");

            //If the folder is found calculate the sum
            if (subFolder != null)
            {
                Console.WriteLine(subFolder.CalculateSum());
            }
        }
    }
}
