namespace Methods
{
    using System;
    using System.Threading;
    using System.Globalization;
    class Methods
    {
        static double CalcTriangleArea(double sideA, double sideB, double sideC)
        {
            var sidesAreNegative = sideA <= 0 || sideB <= 0 || sideC <= 0;
            if (sidesAreNegative)
            {
                throw new ArgumentException("A triangle cannot have a negative side");
            }
            var triangleIsInvalid = sideA + sideB <= sideC || sideB + sideC <= sideA || sideA + sideC <= sideB;
            if (triangleIsInvalid)
            {
                throw new ArgumentException("The sum of the lengths of each two sides should be longer than the third one");
            }
            double halfPerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
            return area;
        }

        static string DigitToText(int digit)
        {
            switch (digit)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException("You did not enter a valid number!!");
            }
        }

        static int FindMax(params int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentNullException("The array you have provided is empty!");
            }
            var max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        static void PrintAsNumber(object number, string format)
        {
            string resultFormat;
            switch (format)
            {
                case "f": resultFormat = "{0:f2}"; break;
                case "%": resultFormat = "{0:p0}"; break;
                case "r": resultFormat = "{0,8}"; break;
                default: throw new ArgumentException("The format you have provided is incorrect!");
            }

            Console.WriteLine(resultFormat, number);
        }


        static double CalcDistance(double startPointX, double startPointY, double endPointX, double endPointY, out bool isHorizontal, out bool isVertical)
        {
            isHorizontal = (startPointY == endPointY);
            isVertical = (startPointX == endPointX);

            double distance = Math.Sqrt((endPointX - startPointX) * (endPointX - startPointX) + (endPointY - startPointY) * (endPointY - startPointY));
            return distance;
        }

        static void Main()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
            Console.WriteLine(CalcTriangleArea(3, 4, 5));

            Console.WriteLine(DigitToText(5));

            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintAsNumber(1.3, "f");
            PrintAsNumber(0.75, "%");
            PrintAsNumber(2.30, "r");

            bool horizontal, vertical;
            Console.WriteLine(CalcDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 03/17/1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 11/03/1993";

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}