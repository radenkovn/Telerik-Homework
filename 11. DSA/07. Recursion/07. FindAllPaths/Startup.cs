namespace _07.FindAllPaths
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Startup
    {
        static int counter = 0;
        static string empty = "-";
        static string path = "";
        static string taken = "X";
        static string start = "S";
        static string[,] matrix = 
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

        static int[][] directions =
        {
            new int[]{0, -1},
            new int[]{0, 1},
            new int[]{1, 0},
            new int[]{-1, 0}
        };

        static int rows;
        static int cols;

        static void Main()
        {
            var start = matrix[0, 0];
            rows = matrix.GetLength(0);
            cols = matrix.GetLength(1);
            var end = matrix[rows - 1, cols - 1];
            FindWays(0, 0, rows - 1, cols - 1);
        }

        static void FindWays(int currentRow, int currentCol, int destinationRow, int destinationCol)
        {
            if (currentRow == destinationRow && currentCol == destinationCol)
            {
                PrintMatrix();
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

        private static void PrintMatrix()
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
            Console.WriteLine("--------");

        }
    }
}
