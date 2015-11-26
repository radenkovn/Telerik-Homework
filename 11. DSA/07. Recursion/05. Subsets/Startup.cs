namespace _05.Subsets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        private static string[] values;
        private static int n;
        private static int k;

        public static void Main()
        {
            //int n = int.Parse(Console.ReadLine());
            n = 3;
            k = 2;
            var arr = new string[n];
            values = new string[] { "hi", "a", "b" };
            SimulateNested(arr, 0);
        }

        public static void SimulateNested(string[] arr, int index)
        {

            if (index >= k)
            {
                PrintArr(arr);
                return;
            }

            for (int i = 0; i < n; i++)
            {
                arr[index] = values[i];
                SimulateNested(arr, index + 1);
            }
        }

        public static void PrintArr<T>(IEnumerable<T> arr)
        {
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
