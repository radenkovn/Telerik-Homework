using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_and_Folder.Classes
{
    public class MyFolder
    {
        public MyFolder(string path, string name)
        {

            this.Name = name;
            this.Files = new HashSet<MyFile>();
            this.Folders = new HashSet<MyFolder>();

            try
            {
                //var files = Directory.GetFiles(path);
                DirectoryInfo di = new DirectoryInfo(path);
                var files = di.GetFiles();
                foreach (var file in files)
                {
                    this.Files.Add(new MyFile(file.Name, file.Length));
                }
                //var directories = Directory.GetDirectories(path);

                var directories = di.GetDirectories();
                foreach (var directory in directories)
                {
                    this.Folders.Add(new MyFolder(directory.FullName, directory.Name));
                }
            }
            catch
            {
                Console.WriteLine("Error - Probably unauthorized");
            }


        }

        public string Name { get; set; }

        public ICollection<MyFile> Files { get; set; }

        public ICollection<MyFolder> Folders { get; set; }

        public MyFolder FindSubFolder(string name)
        {
            var folders = this.Folders;

            foreach (var file in folders)
            {
                if (file.Name == name)
                {
                    return file;
                }
            }
            foreach (var folder in folders)
            {
                FindSubFolder(name);
            }
            return null;
        }

        //public MyFolder FindFolder(string name)
        //{
        //    var folder = this.Folders.FirstOrDefault(f => f.Name == name);
        //    return folder;
        //}

        public long CalculateSum()
        {
            long sum = 0;

            if (this.Files.Count == 0 && this.Folders.Count == 0)
            {
                return 0;
            }

            sum += CalculateSum(this.Files);

            foreach (var node in this.Folders)
            {
                sum += node.CalculateSum();
            }
            return sum;
        }

        private long CalculateSum(ICollection<MyFile> files)
        {
            long sum = 0;
            foreach (var file in files)
            {
                sum += file.Size;
            }
            return sum;
        }
    }
}
