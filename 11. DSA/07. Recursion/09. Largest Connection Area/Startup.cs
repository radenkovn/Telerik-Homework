﻿namespace _09.Largest_Connection_Area
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        private static int rows;
        private static int cols;
        private static int maxCounter = int.MinValue;
        private static bool found = false;
        private static int counter = 0;
        private static string empty = "-";
        private static string path = "";
        private static string taken = "X";
        private static string start = "S";

        public static string[,] matrix = 
        {
            //{start, taken, empty, empty},
            //{empty, empty, empty, empty},
            //{empty, taken, empty, empty},
            //{empty, empty, empty, empty}

            {start, taken, empty, empty, empty, empty, empty},
            {empty, taken, taken, taken, empty, taken, empty},
            {empty, empty, empty, taken, empty, empty, empty},
            {empty, taken, empty, empty, empty, taken, empty},
            {empty, empty, empty, empty, empty, empty, empty}
        };

        public static Dictionary<int, string[,]> resultDict = new Dictionary<int, string[,]>();

        public static int[][] directions =
        {
            new int[] {-1, 0},
            new int[] {0, 1},
            new int[] {1, 0},
            new int[] {0, -1},
        };

        public static void Main()
        {
            var start = matrix[0, 0];
            rows = matrix.GetLength(0);
            cols = matrix.GetLength(1);
            var end = matrix[rows - 1, cols - 1];
            FindWays(0, 0, rows - 1, cols - 1);
            Console.WriteLine();
            Console.WriteLine("The longest way is {0} steps long!", maxCounter);
            Console.WriteLine();
            PrintMatrix(resultDict[maxCounter]);

        }

        public static void FindWays(int currentRow, int currentCol, int destinationRow, int destinationCol)
        {
            if (currentRow == destinationRow && currentCol == destinationCol)
            {
                //PrintMatrix();
                maxCounter = Math.Max(maxCounter, counter);
                if (!resultDict.ContainsKey(maxCounter))
                {
                    resultDict[maxCounter] = matrix.Clone() as string[,];
                }
                return;
            }

            for (int i = 0; i < 4; i++)
            {
                var dirX = directions[i][0];
                var dirY = directions[i][1];
                var rowTocheck = currentRow + dirX;
                var colToCheck = currentCol + dirY;

                if (rowTocheck < 0 || rowTocheck >= rows || colToCheck < 0 || colToCheck >= cols)
                {
                    continue;
                }

                if (matrix[rowTocheck, colToCheck] == empty)
                {
                    counter++;
                    matrix[rowTocheck, colToCheck] = path + counter;
                    FindWays(rowTocheck, colToCheck, destinationRow, destinationCol);
                    matrix[rowTocheck, colToCheck] = empty;
                    counter--;
                }
            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("{0,3}", matrix[i, j].ToString());
                }

                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine("--------------------");
        }
    }
}
