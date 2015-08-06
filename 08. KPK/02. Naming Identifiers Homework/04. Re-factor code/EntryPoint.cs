namespace MineSweeper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using MineSweeper.Classes;
    public class MineSweeperGame
    {
        static void Main()
        {
            string nextCommand = string.Empty;
            char[,] playField = CreatePlayField();
            char[,] bombField = CreateBombField();
            int counter = 0;
            bool bombHit = false;
            List<Point> topScores = new List<Point>(6);
            int currentRow = 0;
            int currentCol = 0;
            bool gameInInitialState = true;
            const int possibleTurns = 35;
            bool allPossibleOpen = false;

            do
            {
                if (gameInInitialState)
                {
                    Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
                    " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    PrintPlayfield(playField);
                    gameInInitialState = false;
                }
                Console.Write("Daj red i kolona : ");
                nextCommand = Console.ReadLine().Trim();
                if (nextCommand.Length >= 3)
                {
                    if (int.TryParse(nextCommand[0].ToString(), out currentRow) &&
                    int.TryParse(nextCommand[2].ToString(), out currentCol) &&
                        currentRow <= playField.GetLength(0) && currentCol <= playField.GetLength(1))
                    {
                        nextCommand = "turn";
                    }
                }
                switch (nextCommand)
                {
                    case "top":
                        Ranking(topScores);
                        break;
                    case "restart":
                        playField = CreatePlayField();
                        bombField = CreateBombField();
                        PrintPlayfield(playField);
                        bombHit = false;
                        gameInInitialState = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (bombField[currentRow, currentCol] != '*')
                        {
                            if (bombField[currentRow, currentCol] == '-')
                            {
                                ExecuteTurn(playField, bombField, currentRow, currentCol);
                                counter++;
                            }
                            if (possibleTurns == counter)
                            {
                                allPossibleOpen = true;
                            }
                            else
                            {
                                PrintPlayfield(playField);
                            }
                        }
                        else
                        {
                            bombHit = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }
                if (bombHit)
                {
                    PrintPlayfield(bombField);
                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " +
                        "Daj si niknejm: ", counter);
                    string currentNickName = Console.ReadLine();
                    Point currentScore = new Point(currentNickName, counter);
                    if (topScores.Count < 5)
                    {
                        topScores.Add(currentScore);
                    }
                    else
                    {
                        for (int i = 0; i < topScores.Count; i++)
                        {
                            if (topScores[i].Points < currentScore.Points)
                            {
                                topScores.Insert(i, currentScore);
                                topScores.RemoveAt(topScores.Count - 1);
                                break;
                            }
                        }
                    }
                    topScores.Sort((Point r1, Point r2) => r2.Name.CompareTo(r1.Name));
                    topScores.Sort((Point r1, Point r2) => r2.Points.CompareTo(r1.Points));
                    Ranking(topScores);

                    playField = CreatePlayField();
                    bombField = CreateBombField();
                    counter = 0;
                    bombHit = false;
                    gameInInitialState = true;
                }
                if (allPossibleOpen)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    PrintPlayfield(bombField);
                    Console.WriteLine("Daj si imeto, batka: ");
                    string currentNickName = Console.ReadLine();
                    Point Points = new Point(currentNickName, counter);
                    topScores.Add(Points);
                    Ranking(topScores);
                    playField = CreatePlayField();
                    bombField = CreateBombField();
                    counter = 0;
                    allPossibleOpen = false;
                    gameInInitialState = true;
                }
            }
            while (nextCommand != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void Ranking(List<Point> points)
        {
            Console.WriteLine("\nTo4KI:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii",
                        i + 1, points[i].Name, points[i].Points);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void ExecuteTurn(char[,] currentField,
            char[,] currentBombs, int currentRow, int currentCol)
        {
            char bombCount = CountBombs(currentBombs, currentRow, currentCol);
            currentBombs[currentRow, currentCol] = bombCount;
            currentField[currentRow, currentCol] = bombCount;
        }

        private static void PrintPlayfield(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreatePlayField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] CreateBombField()
        {
            int bomrRows = 5;
            int bombCols = 10;
            char[,] bombField = new char[bomrRows, bombCols];

            for (int i = 0; i < bomrRows; i++)
            {
                for (int j = 0; j < bombCols; j++)
                {
                    bombField[i, j] = '-';
                }
            }

            List<int> bombList = new List<int>();
            while (bombList.Count < 15)
            {
                Random randomGenerator = new Random();
                int nextRandom = randomGenerator.Next(50);
                if (!bombList.Contains(nextRandom))
                {
                    bombList.Add(nextRandom);
                }
            }

            foreach (int bomb in bombList)
            {
                int currentCol = (bomb / bombCols);
                int currentRow = (bomb % bombCols);
                if (currentRow == 0 && bomb != 0)
                {
                    currentCol--;
                    currentRow = bombCols;
                }
                else
                {
                    currentRow++;
                }
                bombField[currentCol, currentRow - 1] = '*';
            }

            return bombField;
        }

        private static void smetki(char[,] currentField)
        {
            int rows = currentField.GetLength(0);
            int cols = currentField.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (currentField[i, j] != '*')
                    {
                        char bombCount = CountBombs(currentField, i, j);
                        currentField[i, j] = bombCount;
                    }
                }
            }
        }

        private static char CountBombs(char[,] currentField, int currentRow, int currentCol)
        {
            int bombCount = 0;
            int rows = currentField.GetLength(0);
            int cols = currentField.GetLength(1);

            if (currentRow - 1 >= 0)
            {
                if (currentField[currentRow - 1, currentCol] == '*')
                {
                    bombCount++;
                }
            }
            if (currentRow + 1 < rows)
            {
                if (currentField[currentRow + 1, currentCol] == '*')
                {
                    bombCount++;
                }
            }
            if (currentCol - 1 >= 0)
            {
                if (currentField[currentRow, currentCol - 1] == '*')
                {
                    bombCount++;
                }
            }
            if (currentCol + 1 < cols)
            {
                if (currentField[currentRow, currentCol + 1] == '*')
                {
                    bombCount++;
                }
            }
            if ((currentRow - 1 >= 0) && (currentCol - 1 >= 0))
            {
                if (currentField[currentRow - 1, currentCol - 1] == '*')
                {
                    bombCount++;
                }
            }
            if ((currentRow - 1 >= 0) && (currentCol + 1 < cols))
            {
                if (currentField[currentRow - 1, currentCol + 1] == '*')
                {
                    bombCount++;
                }
            }
            if ((currentRow + 1 < rows) && (currentCol - 1 >= 0))
            {
                if (currentField[currentRow + 1, currentCol - 1] == '*')
                {
                    bombCount++;
                }
            }
            if ((currentRow + 1 < rows) && (currentCol + 1 < cols))
            {
                if (currentField[currentRow + 1, currentCol + 1] == '*')
                {
                    bombCount++;
                }
            }
            return char.Parse(bombCount.ToString());
        }
    }
}