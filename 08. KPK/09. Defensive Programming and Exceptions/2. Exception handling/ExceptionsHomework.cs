namespace ExceptionHandling
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Diagnostics;

    using ExceptionHandling.Classes;

    class ExceptionsHomework
    {
        public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("The array you have provided is equal to null!");
            }
            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException("The start index of a subsequence cannot be less than 0!");
            }
            if (startIndex > arr.Length - 1)
            {
                throw new ArgumentOutOfRangeException("The start index of a subsequence cannot be greater the array's length!");
            }
            if (startIndex + count > arr.Length)
            {
                throw new ArgumentOutOfRangeException("The start index + count provided for a subsequence cannot have a sum greater than the array's length!");
            }
            if (count < 0)
            {
                throw new ArgumentException("The count of a subsequence cannot have a negative value!");
            }
            List<T> result = new List<T>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }
            return result.ToArray();
        }

        public static string ExtractEnding(string str, int count)
        {

            if (count > str.Length)
            {
                throw new ArgumentOutOfRangeException("The count provided for an ExtractEnding cannot be greater than the string's length!");
            }
            if (count < 0)
            {
                throw new ArgumentException("The count of an ExtractEnding cannot have a negative value!");
            }
            StringBuilder result = new StringBuilder();
            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }
            return result.ToString();
        }

        public static bool CheckPrime(int number)
        {
            if (number <= 1)
            {
                //You could throw an exception, but I don't think it is necessary, as the result false is correct. If you still wanted to do it, this is how it would look like:
                //throw new ArgumentException("The number you want to check should be greater than 1!");
                return false;
            }
            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main()
        {
            var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(String.Join(" ", subarr));

            var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(String.Join(" ", allarr));

            var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(String.Join(" ", emptyarr));

            Console.WriteLine(ExtractEnding("I love C#", 2));
            Console.WriteLine(ExtractEnding("Nakov", 4));
            Console.WriteLine(ExtractEnding("beer", 4));
            try
            {
                Console.WriteLine(ExtractEnding("Hi", 100));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            if (CheckPrime(23))
            {
                Console.WriteLine("23 is prime.");
            }
            else
            {
                Console.WriteLine("23 is not prime");
            }
            if (CheckPrime(33))
            {
                Console.WriteLine("33 is prime.");
            }
            else
            {
                Console.WriteLine("33 is not prime");
            }
            List<Exam> peterExams = new List<Exam>()
            {
                new SimpleMathExam(2),
                new CSharpExam(55),
                new CSharpExam(100),
                new SimpleMathExam(1),
                new CSharpExam(0),
            };
            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
    }
}
