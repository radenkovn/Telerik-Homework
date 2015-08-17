namespace RefactoringMatrix
{
    using System;
    using RefactoringMatrix.Classes;
    public class Matrix
    {
        public static Cell GetNewDirection(int directionRow, int directionCol)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int changeDirection = 0;
            for (int count = 0; count < 8; count++)
            {
                if (dirX[count] == directionRow && dirY[count] == directionCol)
                {
                    changeDirection = count;
                    break;
                }
            }
            if (changeDirection == 7)
            {
                directionRow = dirX[0]; directionCol = dirY[0];
            }
            else
            {
                directionRow = dirX[changeDirection + 1];
                directionCol = dirY[changeDirection + 1];
            }
            return new Cell(directionRow, directionCol);
        }

        public static bool ValidateDirection(int[,] matrix, int currentRow, int currentCol)
        {
            int[] dirRow = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirCol = { 1, 0, -1, -1, -1, 0, 1, 1 };
            var length = matrix.GetLength(0);
            for (int i = 0; i < 8; i++)
            {
                if (currentRow + dirRow[i] >= length || currentRow + dirRow[i] < 0)
                {
                    dirRow[i] = 0;
                }
                if (currentCol + dirCol[i] >= length || currentCol + dirCol[i] < 0)
                {
                    dirCol[i] = 0;
                }
            }
            for (int i = 0; i < 8; i++)
            {
                if (matrix[currentRow + dirRow[i], currentCol + dirCol[i]] == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static Cell GetNextCell(int[,] matrix)
        {
            int x = 0;
            int y = 0;
            int length = matrix.GetLength(0);
            for (int row = 0; row < length; row++)
            {
                for (int col = 0; col < length; col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        x = row;
                        y = col;
                        return new Cell(x, y);
                    }
                }
            }
            return null;
        }

        public static void PrintMatrix(int[,] matrix, int matrixSize)
        {
            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    Console.Write("{0,4}", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        public static void FillMatrix(int[,] matrix, int matrixSize)
        {
            int currentNumber = 1;
            int currentRow = 0;
            int currentCol = 0;
            int destinationRow = 1;
            int destinationCol = 1;
            var nextCell = GetNextCell(matrix);
            while (nextCell != null)
            {
                matrix[currentRow, currentCol] = currentNumber;
                if (!ValidateDirection(matrix, currentRow, currentCol))
                {
                    nextCell = GetNextCell(matrix);
                    if (nextCell != null)
                    {
                        currentRow = nextCell.Row;
                        currentCol = nextCell.Col;
                    }
                    continue;
                }

                var destinationRowOutOfRange = (currentRow + destinationRow >= matrixSize || currentRow + destinationRow < 0);
                var destinationColOutOfRange = (currentCol + destinationCol >= matrixSize || currentCol + destinationCol < 0);
                var destinationOutOfRange = destinationColOutOfRange || destinationRowOutOfRange || matrix[currentRow + destinationRow, currentCol + destinationCol] != 0;
                while (destinationOutOfRange)
                {
                    var newDirection = GetNewDirection(destinationRow, destinationCol);
                    destinationRow = newDirection.Row;
                    destinationCol = newDirection.Col;

                    destinationRowOutOfRange = (currentRow + destinationRow >= matrixSize) || (currentRow + destinationRow < 0);
                    destinationColOutOfRange = (currentCol + destinationCol >= matrixSize) || (currentCol + destinationCol < 0);
                    destinationOutOfRange = destinationColOutOfRange || destinationRowOutOfRange || matrix[currentRow + destinationRow, currentCol + destinationCol] != 0;
                }
                currentRow += destinationRow;
                currentCol += destinationCol;
                currentNumber++;
            }
        }

        public static void Main(string[] args)
        {
            int matrixSize = 15;
            int[,] matrix = new int[matrixSize, matrixSize];
            FillMatrix(matrix, matrixSize);
            PrintMatrix(matrix, matrixSize);
        }
    }
}