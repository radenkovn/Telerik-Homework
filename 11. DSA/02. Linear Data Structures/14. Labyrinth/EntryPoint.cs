using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Labyrinth
{
    class EntryPoint
    {
        static void Main()
        {
            var labyrinth = new char[,] { 
                {'0', '0', '0', 'X', '0', 'X'},
                {'0', 'x', '0', 'X', '0', 'X'},
                {'0', '*', 'X', '0', 'X', '0'},
                {'0', 'X', '0', '0', '0', '0'},
                {'0', '0', '0', 'X', 'X', '0'},
                {'0', '0', '0', 'X', '0', 'X'},
            };

        }

        public static void FillLabyrinth(char[,] matrix)
        {
            var size = matrix.GetLength(0);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    var currentCell = matrix[i, j];
                    bool isEmpty = currentCell == '0' || currentCell == 'X';
                    if (!isEmpty)
                    {

                    }
                }
            }
        }

        public static void FillNeighbours(char[,] matrix)
        {

        }
    }
}
