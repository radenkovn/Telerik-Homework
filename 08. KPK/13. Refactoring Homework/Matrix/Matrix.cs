namespace RefactoringMatrix
{
    using System;
    class WalkInMatrica
    {
        static void change(ref int dx, ref int dy)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int cd = 0;
            for (int count = 0; count < 8; count++)
            {
                if (dirX[count] == dx && dirY[count] == dy)
                {
                    cd = count;
                    break;
                }
            }
            if (cd == 7)
            {
                dx = dirX[0]; dy = dirY[0];
                return;
            }
            dx = dirX[cd + 1];
            dy = dirY[cd + 1];
        }

        static bool proverka(int[,] arr, int x, int y)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            for (int i = 0; i < 8; i++)
            {
                if (x + dirX[i] >= arr.GetLength(0) || x + dirX[i] < 0) dirX[i] = 0;
                if (y + dirY[i] >= arr.GetLength(0) || y + dirY[i] < 0) dirY[i] = 0;
            }
            for (int i = 0; i < 8; i++)
            {
                if (arr[x + dirX[i], y + dirY[i]] == 0)
                {
                    return true;
                }
            }
            return false;
        }

        static void find_cell(int[,] arr, out int x, out int y)
        {
            x = 0;
            y = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        x = i; y = j;
                        return;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int matrixSize = 3;
            int[,] matrix = new int[matrixSize, matrixSize];
            int k = 1;
            int i = 0;
            int j = 0;
            int dx = 1;
            int dy = 1;
            while (true)
            { //malko e kofti tova uslovie, no break-a raboti 100% : )
                matrix[i, j] = k;

                if (!proverka(matrix, i, j))
                {
                    break;
                } // prekusvame ako sme se zadunili
                if (i + dx >= matrixSize || i + dx < 0 || j + dy >= matrixSize || j + dy < 0 || matrix[i + dx, j + dy] != 0)
                {
                    while ((i + dx >= matrixSize || i + dx < 0 || j + dy >= matrixSize || j + dy < 0 || matrix[i + dx, j + dy] != 0))
                    {
                        change(ref dx, ref dy);
                    }
                }
                i += dx; j += dy; k++;
            }
            for (int p = 0; p < matrixSize; p++)
            {
                for (int q = 0; q < matrixSize; q++) Console.Write("{0,3}", matrix[p, q]);
                Console.WriteLine();
            }
            find_cell(matrix, out i, out j);
            if (i != 0 && j != 0)
            { // taka go napravih, zashtoto funkciqta ne mi davashe da ne si definiram out parametrite
                dx = 1; dy = 1;
                while (true)
                { //malko e kofti tova uslovie, no break-a raboti 100% : )
                    matrix[i, j] = k;
                    if (!proverka(matrix, i, j))
                    {
                        break;
                    }// prekusvame ako sme se zadunili
                    if (i + dx >= matrixSize || i + dx < 0 || j + dy >= matrixSize || j + dy < 0 || matrix[i + dx, j + dy] != 0)
                    {
                        while ((i + dx >= matrixSize || i + dx < 0 || j + dy >= matrixSize || j + dy < 0 || matrix[i + dx, j + dy] != 0))
                        {
                            change(ref dx, ref dy);
                        }
                    }
                    i += dx; j += dy; k++;
                }
            }
            for (int pp = 0; pp < matrixSize; pp++)
            {
                for (int qq = 0; qq < matrixSize; qq++)
                {
                    Console.Write("{0,3}", matrix[pp, qq]);
                }
                Console.WriteLine();
            }
        }
    }
}