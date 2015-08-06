namespace AssertionsTask
{
    using System;
    using System.Linq;
    using System.Diagnostics;

    class AssertionsHomework
    {
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            AssertIfNullOrEmptyArrayArray(arr);

            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            AssertIfNullOrEmptyArrayArray(arr);

            //Debug.Assert(startIndex != null, "The start index cannot be null");
            //Debug.Assert(endIndex != null, "The end index cannot be null");
            Debug.Assert(startIndex >= 0, "The start index cannot be less than 0");
            Debug.Assert(startIndex < arr.Length - 1, "The start index cannot be greater or equal than the array's length");
            Debug.Assert(endIndex >= startIndex, "The end index cannot be less than the start index");
            Debug.Assert(endIndex <= arr.Length - 1, "The end index cannot be more than the array's length");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }
            return minElementIndex;
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            Debug.Assert(x != null, "The first number of the comparison cannot have a null value");
            Debug.Assert(y != null, "The first number of the comparison cannot have a null value");

            T oldX = x;
            x = y;
            y = oldX;
        }

        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            AssertIfNullOrEmptyArrayArray(arr);
            Debug.Assert(CheckIfSorted(arr), "The array you search in should be sorted!");

            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            AssertIfNullOrEmptyArrayArray(arr);
            //Debug.Assert(startIndex != null, "The start index cannot be null");
            //Debug.Assert(endIndex != null, "The end index cannot be null");
            Debug.Assert(startIndex >= 0, "The start index cannot be less than 0");
            Debug.Assert(startIndex <= arr.Length - 1, "The start index cannot be greater than the array's length");
            Debug.Assert(endIndex >= startIndex, "The end index cannot be less than the start index");
            Debug.Assert(endIndex <= arr.Length - 1, "The end index cannot be more than the array's length");


            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }
                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            // Searched value not found
            return -1;
        }

        //Helper methods
        private static bool CheckIfSorted<T>(T[] arr) where T : IComparable<T>
        {
            AssertIfNullOrEmptyArrayArray(arr);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i].CompareTo(arr[i + 1]) > 0)
                {
                    return false;
                }
            }
            return true;
        }

        private static void AssertIfNullOrEmptyArrayArray<T>(T[] arr) where T : IComparable<T>
        {
            Debug.Assert(arr != null, "The array cannot have a null value!");
            //Debug.Assert(arr.Length > 0, "The array cannot have a length of 0 or less!");
        }


        static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            SelectionSort(new int[0]); // Test sorting empty array
            SelectionSort(new int[1]); // Test sorting single element array

            Console.WriteLine(BinarySearch(arr, -1000));
            Console.WriteLine(BinarySearch(arr, 0));
            Console.WriteLine(BinarySearch(arr, 17));
            Console.WriteLine(BinarySearch(arr, 10));
            Console.WriteLine(BinarySearch(arr, 1000));
        }
    }
}