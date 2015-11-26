using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var a1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var a2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var sorted = new int[n];

            for (int i = 0; i < n; i++)
            {
                sorted[a1[i] - 1] = i;
            }

            for (int i = 0; i < n; i++)
            {
                
            }
            var c = 1;
        }
    }
}
