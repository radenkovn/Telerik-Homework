namespace LoverOfTwo
{
    using System;
    using System.Numerics;
    class EntryPoint
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            BigInteger[,] matrix = FillMatrix(rows, cols);

            int commandCount = int.Parse(Console.ReadLine());

            string[] commandsStr = Console.ReadLine().Split(' ');

            decimal[] commands = new decimal[commandCount];
            for (int i = 0; i < commands.Length; i++)
            {
                commands[i] = decimal.Parse(commandsStr[i]);
            }
            int currentRow = rows - 1;
            int currentCol = 0;

            int coefficient = Math.Max(rows, cols);
            BigInteger totalSum = 0;
            for (int i = 0; i < commands.Length; i++)
            {
                decimal code = commands[i];
                int pathRow = (int)(code / coefficient);
                int pathCol = (int)(code % coefficient);
                totalSum += sumToPath(currentRow, currentCol, pathRow, pathCol, matrix);

                currentRow = pathRow;
                currentCol = pathCol;
            }

            Console.WriteLine(totalSum);
        }

        static BigInteger[,] FillMatrix(int rows, int cols)
        {
            BigInteger[,] matrix = new BigInteger[rows, cols];
            matrix[rows - 1, 0] = 1;
            for (int row = rows - 2; row >= 0; row--)
            {
                matrix[row, 0] = matrix[row + 1, 0] * 2;
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 1; col < cols; col++)
                {
                    matrix[row, col] = matrix[row, col - 1] * 2;
                }
            }

            return matrix;
        }

        static BigInteger sumToPath(int currentRow, int currentCol, int pathRow, int pathCol, BigInteger[,] matrix)
        {
            BigInteger sum = 0;
            if (currentRow > pathRow)
            {
                for (int row = currentRow; row >= pathRow; row--)
                {
                    sum += matrix[row, currentCol];
                    matrix[row, currentCol] = 0;
                }
                sum += SumByColumn(currentRow, currentCol, pathRow, pathCol, matrix);
            }
            else if (currentRow < pathRow)
            {
                for (int row = currentRow; row <= pathRow; row++)
                {
                    sum += matrix[row, currentCol];
                    matrix[row, currentCol] = 0;
                }
                sum += SumByColumn(currentRow, currentCol, pathRow, pathCol, matrix);
            }
            else if (currentRow == pathRow)
            {
                sum += SumByColumn(currentRow, currentCol, pathRow, pathCol, matrix);
            }

            return sum;
        }

        static BigInteger SumByColumn(int currentRow, int currentCol, int pathRow, int pathCol, BigInteger[,] matrix)
        {
            BigInteger sum = 0;
            if (currentCol < pathCol)
            {
                for (int col = currentCol; col <= pathCol; col++)
                {
                    sum += matrix[pathRow, col];
                    matrix[pathRow, col] = 0;
                }
            }
            else if (currentCol > pathCol)
            {
                for (int col = currentCol; col >= pathCol; col--)
                {
                    sum += matrix[pathRow, col];
                    matrix[pathRow, col] = 0;
                }
            }

            return sum;
        }
    }
}
