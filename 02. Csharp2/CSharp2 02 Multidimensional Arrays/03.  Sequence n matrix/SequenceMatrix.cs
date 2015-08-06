//PROBLEM 03

//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.


using System;

class SequenceMatrix
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


        // IN CASE YOU DONT, USE THIS: 

        string[,] matrix = new string[,] {    { "1" ,        "1",       "3",    "1",    "1" ,    "4",     "1",    "1"},
                                              { "16" ,       "4",       "14",   "13",   "12" ,   "11",    "10",   "37"},
                                              { "17" ,       "18",      "19",   "20",   "21" ,   "22",    "37",   "24"} ,
                                              { "254" ,      "31",      "30",   "1",    "28" ,   "2",     "26",   "25"} ,
                                              { "33" ,       "223",     "43",   "52",   "37" ,   "58",    "67",   "1000"}, 
                                              { "34" ,       "42",      "256",  "4",    "54" ,   "1",     "1000",   "69"} ,
                                              { "35" ,       "40",      "37",   "50",   "55" ,   "1000",    "2",    "70"} ,
                                              { "36" ,       "37",      "46",   "49",   "1000" ,   "61",    "64",   "1"} ,
                                              { "37" ,       "38",      "47",   "1000",   "57" ,   "62",    "63",   "72"} 
                                         };


        //Printing the matrix
        Console.WriteLine("Our Matrix is: ");
        Console.WriteLine();
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,6} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();


        int maxAll = 0;
        int maxRow = 0;
        int maxCol = 0;

        //checking Rows direction ->  --
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int maxCurrent = 1;
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    string currentString = matrix[row, col];
                    int currentCol = col;
                    while (currentCol < matrix.GetLength(1) - 1 && currentString == matrix[row, currentCol + 1])
                    {

                        maxCurrent++;
                        currentCol++;
                        col = currentCol;
                    }
                    if (maxCurrent > maxAll)
                    {
                        maxAll = maxCurrent;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }
        }
        // Checking Columns direction -> |
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
            {
                int maxCurrent = 1;
                if (matrix[rows, cols] == matrix[rows + 1, cols])
                {
                    string currentString = matrix[rows, cols];
                    int currentRow = rows;
                    while (currentRow < matrix.GetLength(0) - 1 && currentString == matrix[currentRow + 1, cols])
                    {
                        maxCurrent++;
                        currentRow++;
                        rows = currentRow;
                    }
                    if (maxCurrent > maxAll)
                    {
                        maxAll = maxCurrent;
                        maxRow = rows;
                        maxCol = cols;
                    }
                }
            }
        }
        //Checking Positive Diagonals direction-> \
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int maxCurrent = 1;
                if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    string currentString = matrix[row, col];
                    int currentCol = col;
                    int currentRow = row;
                    while (currentCol < matrix.GetLength(1) - 1 &&
                             currentRow < matrix.GetLength(0) - 1 &&
                            currentString == matrix[currentRow + 1, currentCol + 1])
                    {

                        maxCurrent++;
                        currentCol++;
                        currentRow++;
                    }
                    if (maxCurrent > maxAll)
                    {
                        maxAll = maxCurrent;
                        maxRow = row;
                        maxCol = col;
                    }
                }

            }
        }

        //Checking Negative Diagonals direction -> /

        for (int row = matrix.GetLength(0) - 1; row > 1; row--)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int maxCurrent = 1;
                if (matrix[row, col] == matrix[row - 1, col + 1])
                {
                    string currentString = matrix[row, col];
                    int currentCol = col;
                    int currentRow = row;
                    while (currentCol < matrix.GetLength(1) - 1 &&
                           currentRow > 0 &&
                           currentString == matrix[currentRow - 1, currentCol + 1])
                    {

                        maxCurrent++;
                        currentCol++;
                        currentRow--;
                    }
                    if (maxCurrent > maxAll)
                    {
                        maxAll = maxCurrent;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }
        }

        if (maxAll == 0)
        {
            Console.WriteLine("There is no sequence!");
        }
        else
        {
            string[] maxSequence = new string[maxAll];
            for (int i = 0; i < maxAll; i++)
            {
                maxSequence[i] = matrix[maxRow, maxCol];
            }
            Console.WriteLine("The maximum sequence is this: ");
            Console.WriteLine();
            Console.WriteLine(string.Join(", ", maxSequence));
            Console.WriteLine();
        }

    }
}

