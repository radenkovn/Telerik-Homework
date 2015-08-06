//PROBLEM 1
//Write a program that fills and prints a matrix of size (n, n) as shown below:


//a) 	 	 	
//1 	5 	9 	13
//2 	6 	10 	14
//3 	7 	11 	15
//4 	8 	12 	16

//b)

//1 	8 	9 	16
//2 	7 	10 	15
//3 	6 	11 	14
//4 	5 	12 	13

//c)
//7 	11 	14 	16
//4 	8 	12 	15
//2 	5 	9 	13
//1 	3 	6 	10

//d)*	
//1 	12 	11 	10
//2 	13 	16 	9
//3 	14 	15 	8
//4 	5 	6 	7


using System;
class FillMatix
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(2);
        int[,] aMatrix = new int[n, n];
        int[,] bMatrix = new int[n, n];
        int[,] cMatrix = new int[n, n];
        int[,] dMatrix = new int[n, n];

        //a)

        int counter = 1;
        for (int col = 0; col < aMatrix.GetLength(1); col++)
        {
            for (int wrow = 0; wrow < aMatrix.GetLength(0); wrow++)
            {
                aMatrix[wrow, col] = counter;
                counter++;
            }
        }
        Console.WriteLine("Matrix a): ");
        Console.WriteLine();
        for (int row = 0; row < aMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < aMatrix.GetLength(1); col++)
            {
                Console.Write("{0,3} ", aMatrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //b)

        counter = 1;
        for (int col = 0; col < bMatrix.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < bMatrix.GetLength(0); row++)
                {
                    bMatrix[row, col] = counter;
                    counter++;
                }
            }
            else
            {
                for (int row = bMatrix.GetLength(0) - 1; row > -1; row--)
                {
                    bMatrix[row, col] = counter;
                    counter++;
                }
            }
        }

        Console.WriteLine("Matrix b): ");
        Console.WriteLine();
        for (int row = 0; row < bMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < bMatrix.GetLength(1); col++)
            {
                Console.Write("{0,3} ", bMatrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //c)

        counter = 1;
        for (int row = n - 1; row >= 0; row--)
        {
            int rowChanger = row;
            int colCount = n - row;
            for (int col = 0; col < colCount; col++)
            {
                cMatrix[rowChanger, col] = counter;
                counter++;
                rowChanger++;
            }
        }
        for (int col = 1; col < n; col++)
        {
            int colChanger = col;
            int colCount = n - col;
            for (int row = 0; row < colCount; row++)
            {
                cMatrix[row, colChanger] = counter;
                counter++;
                colChanger++;
            }
        }

        Console.WriteLine("Matrix c): ");
        Console.WriteLine();
        for (int row = 0; row < cMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < cMatrix.GetLength(1); col++)
            {
                Console.Write("{0,3} ", cMatrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();



    }
}

