namespace _06.Unique_SubSets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Startup
    {
        static string[] filled;
        static int n;
        static int k;

        public static void Main()
        {
            //n = int.Parse(Console.ReadLine());
            n = 2;
            var arr = new string[n];
            filled = new string[] { "test", "rock", "fun" ,"hello"};
            k = filled.Length;
            SimulateNested(arr, 0, (1 << k) - 1);
        }

        public static void SimulateNested(string[] arr, int index, int mask)
        {
            var n = arr.Length;

            if (index >= n)
            {
                PrintArr(arr);
                return;
            }

            for (int i = 0; i < k; i++)
            {
                if (((mask >> i) & 1) == 1)
                {
                    mask = mask ^ (1 << i);
                    arr[index] = filled[i];
                    SimulateNested(arr, index + 1, mask);
                }
            }
        }

        public static void PrintArr<T>(IEnumerable<T> arr)
        {
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
