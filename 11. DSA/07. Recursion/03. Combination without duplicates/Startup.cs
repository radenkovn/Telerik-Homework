namespace _03.Combination_without_duplicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Startup
    {
        static int k;
        static int n;
        public static void Main()
        {
            //n = int.Parse(Console.ReadLine());
            //k = int.Parse(Console.ReadLine());
            n = 4;
            k = 2;
            var arr = new int[k];
            SimulateNested(arr, 0, 1);
        }

        public static void SimulateNested(int[] arr, int index, int start)
        {
            if (index >= k)
            {
                PrintArr(arr);
                return;
            }

            for (int i = start; i <= n; i++)
            {
                arr[index] = i;
                SimulateNested(arr, index + 1, i + 1);
            }
        }

        public static void PrintArr<T>(IEnumerable<T> arr)
        {
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
