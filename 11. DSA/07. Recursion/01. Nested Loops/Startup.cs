namespace _01.Nested_Loops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            //int n = int.Parse(Console.ReadLine());
            int n = 3;
            var arr = new int[n];
            SimulateNested(arr, 0);
        }

        public static void SimulateNested(int[] arr, int index)
        {
            var n = arr.Length;

            if (index >= n)
            {
                PrintArr(arr);
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                arr[index] = i;
                SimulateNested(arr, index + 1);
            }
        }

        public static void PrintArr<T>(IEnumerable<T> arr)
        {
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
