namespace _04.Permutations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Startup
    {
        static int[] filled;
        static int n;

        public static void Main()
        {
            //n = int.Parse(Console.ReadLine());
            n = 5;
            var arr = new int[n];
            filled = FillArray(n);
            SimulateNested(arr, 0, (1 << n) - 1);
        }

        public static int[] FillArray(int n)
        {
            var arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i + 1;
            }
            return arr;
        }
        public static void SimulateNested(int[] arr, int index, int mask)
        {
            var n = arr.Length;

            if (index >= n)
            {
                PrintArr(arr);
                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (((mask >> i) & 1) == 1)
                {
                    mask = mask ^ (1 << i);
                    arr[index] = filled[i];
                    SimulateNested(arr, index + 1, mask);
                    mask = mask | (1 << i);
                }
            }
        }

        public static void PrintArr<T>(IEnumerable<T> arr)
        {
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
