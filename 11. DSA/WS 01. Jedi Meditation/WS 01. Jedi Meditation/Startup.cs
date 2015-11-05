namespace WS_01.Jedi_Meditation
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var count = Console.ReadLine();
            var sequence = Console.ReadLine();
            var jedis = sequence.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var masters = new List<string>();
            var knights = new List<string>();
            var padawans = new List<string>();
            foreach (var jedi in jedis)
            {
                var firstLetter = jedi.ToLower()[0];
                switch (firstLetter)
                {
                    case 'm': masters.Add(jedi);
                        break;
                    case 'k': knights.Add(jedi);
                        break;
                    case 'p': padawans.Add(jedi);
                        break;
                    default:
                        break;
                }
            }

            var output = string.Join(" ", masters) + " " + string.Join(" ", knights) + " " + string.Join(" ", padawans);
            Console.WriteLine(output);
        }
    }
}
