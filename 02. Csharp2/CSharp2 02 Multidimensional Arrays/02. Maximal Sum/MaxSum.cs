////PROBLEM 2
//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.


using System;

class MaxSum
{
    static void Main()
    {
        //IN CASE YOU WANT TO ENTER A MATRIX UNCOMMENT THIS:



        //Console.Write("Enter n: ");
        //int n = int.Parse(Console.ReadLine());
        //Console.Write("Enter m: ");
        //int m = int.Parse(Console.ReadLine());
        //int[,] matrix = new int[n, m];

        //for (int rows = 0; rows < matrix.GetLength(0); rows++)
        //{
        //    for (int cols = 0; cols < matrix.GetLength(1); cols++)
        //    {
        //        Console.Write("Enter {0},{1}: ", rows, cols);
        //        matrix[rows, cols] = int.Parse(Console.ReadLine());
        //    }
        //}

        // IN CASE YOU DONT USE THIS: 


        int[,] matrix = new int[,] {    { 1,     2,     5 ,     6 ,     -3,     4}, 
                                        { 3,     4,     23,     4,      50,     20 }, 
                                        { 5,     6,     40,     -423,   230,    3 }, 
                                        { 7,     8,     -3,     50,     54,    -60},
                                        { 15,    -8,    -233,   750,    -100,   9970} };


        //BODY

        int maxSum = int.MinValue;
        int maxRow = 0;
        int maxCol = 0;
        for (int rows = 0; rows < matrix.GetLength(0) - 2; rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1) - 2; cols++)
            {
                int sum = matrix[rows, cols] + matrix[rows + 1, cols] + matrix[rows + 2, cols] + matrix[rows, cols + 1] + matrix[rows, cols + 2] + matrix[rows + 1, cols + 1] + matrix[rows + 1, cols + 2] + matrix[rows + 2, cols + 1] + matrix[rows + 2, cols + 2];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxRow = rows;
                    maxCol = cols;
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("The 3x3 square is:");
        Console.WriteLine();
        for (int rows = maxRow; rows < maxRow + 3; rows++)
        {
            for (int cols = maxCol; cols < maxCol + 3; cols++)
            {
                Console.Write("{0,3} ", matrix[rows, cols]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("The sum is: {0}", maxSum);
        Console.WriteLine();

    }
}

