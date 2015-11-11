namespace _01.Text_File
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Startup
    {
        static void Main()
        {
            var dic = new SortedDictionary<string, ICollection<Person>>();
            try
            {
                using (StreamReader sr = new StreamReader("../../Input.txt"))
                {
                    var line = sr.ReadLine();
                    while (line != null)
                    {
                        var words = line.Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        var firstName = words[0];
                        var lastName = words[1];
                        var language = words[2];
                        if (!dic.ContainsKey(language))
                        {
                            dic.Add(language, new SortedSet<Person>());
                        }

                        var personToAdd = new Person(firstName, lastName);
                        dic[language].Add(personToAdd);
                        line = sr.ReadLine();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            var builder = new StringBuilder();

            foreach (var setPair in dic)
            {
                var language = setPair.Key;
                builder.Append(language);
                builder.Append(": ");
                foreach (var person in setPair.Value)
                {
                    builder.Append(person.ToString() + ", ");
                }
                builder.Remove(builder.Length - 2, 2);
                builder.AppendLine();
            }

            Console.WriteLine(builder.ToString());
        }
    }
}
