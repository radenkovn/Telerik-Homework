namespace CatConcert
{
    using System;

    class EntryPoint
    {
        public static void Main(string[] args)
        {
            string catsStr = Console.ReadLine();
            string songsStr = Console.ReadLine();

            int cats = int.Parse(catsStr.Substring(0, catsStr.IndexOf(" ")));
            int songs = int.Parse(songsStr.Substring(0, songsStr.IndexOf(" ")));

            string input = Console.ReadLine();
            if (input == "Mew!")
            {
                Console.WriteLine("No concert!");
            }
            else
            {
                int[,] knownMatrix = ConvertInputToMatrix(cats, songs);

                if (CheckIfOnlyOneSong(cats, songs, knownMatrix))
                {
                    Console.WriteLine(1);
                }
                else if (CheckIfNoInitialConcert(cats, songs, knownMatrix))
                {
                    Console.WriteLine("No concert!");
                }
                else
                {
                    var songCounter = CountSongs(cats, songs, knownMatrix);
                    Console.WriteLine(songCounter);
                }
            }
        }

        public static int[,] ConvertInputToMatrix(int cats, int songs)
        {
            int[,] resultMatrix = new int[songs, cats];
            string input = Console.ReadLine();
            do
            {
                int[] coords = new int[2];
                coords[0] = int.Parse(input.Substring(input.IndexOf("song ") + 4)) - 1;
                coords[1] = int.Parse(input.Substring(3, input.IndexOf(' ', 3))) - 1;
                resultMatrix[coords[0], coords[1]] = 1;
                input = Console.ReadLine();
            }
            while (input != "Mew!");
            return resultMatrix;
        }

        public static bool CheckIfOnlyOneSong(int cats, int songs, int[,] matrix)
        {
            bool found = false;
            var knownMatrix = matrix;
            for (int song = 0; song < songs; song++)
            {
                int rollSum = 0;
                for (int cat = 0; cat < cats; cat++)
                {
                    rollSum += knownMatrix[song, cat];
                }
                if (rollSum == cats)
                {
                    found = true;
                    break;
                }
            }
            return found;
        }

        public static bool CheckIfNoInitialConcert(int cats, int songs, int[,] matrix)
        {
            var knownMatrix = matrix;
            for (int col = 0; col < cats; col++)
            {
                int colSum = 0;
                for (int row = 0; row < songs; row++)
                {
                    colSum += knownMatrix[row, col];
                }
                if (colSum == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static int CountSongs(int cats, int songs, int[,] matrix)
        {
            var knownMatrix = matrix;
            int songCounter = 0;
            int maxSongs = cats;
            while (maxSongs > 0)
            {
                int maxSum = 0;
                int maxRow = 0;
                for (int row = 0; row < songs; row++)
                {
                    int rollSum = 0;
                    for (int col = 0; col < cats; col++)
                    {
                        rollSum += knownMatrix[row, col];
                    }
                    if (rollSum > maxSum)
                    {
                        maxSum = rollSum;
                        maxRow = row;
                    }
                }
                maxSongs = maxSongs - maxSum;
                songCounter++;

                for (int col = 0; col < cats; col++)
                {
                    if (knownMatrix[maxRow, col] == 1)
                    {
                        for (int row = 0; row < songs; row++)
                        {
                            knownMatrix[row, col] = 0;
                        }
                    }
                }
            }
            return songCounter;
        }
    }
}
