namespace PersianRugs
{
    using System;
    class Rugs
    {
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            //First Part of the Rug
            int blankspace;
            for (int i = 0; i < width; i++)
            {
                blankspace = width * 2 - (1 + 2 * i);
                string firstPart = new string('#', i);
                Console.Write(firstPart);
                string secondPart = "\\";
                Console.Write(secondPart);
                if (2 * height < blankspace - 1)
                {
                    string thirdPart = new string(' ', height);
                    Console.Write(thirdPart);
                }
                else
                {
                    string thirdPart = new string(' ', blankspace);
                    Console.Write(thirdPart);
                }

                if (blankspace - 2 * height - 2 > 0)
                {
                    string fourthPart = '\\' + new string('.', blankspace - 2 * height - 2) + '/';
                    Console.Write(fourthPart);
                }

                if (2 * height < blankspace - 1)
                {
                    string thirdPart = new string(' ', height);
                    Console.Write(thirdPart);
                }

                string fifthPart = "/";
                Console.Write(fifthPart);
                string sixthPart = new string('#', i);
                Console.Write(sixthPart);
                Console.WriteLine();
            }

            //Middle Part of the Rug
            string middlePart = new string('#', width) + 'X' + new string('#', width);
            Console.WriteLine(middlePart);

            //Third Part of the Rug
            for (int i = 0; i < width; i++)
            {
                blankspace = width * 2 - (1 + 2 * (width - i - 1));
                string firstPart = new string('#', (width - i - 1));
                Console.Write(firstPart);
                string secondPart = "/";
                Console.Write(secondPart);
                if (2 * height < blankspace - 1)
                {
                    string thirdPart = new string(' ', height);
                    Console.Write(thirdPart);
                }
                else
                {
                    string thirdPart = new string(' ', blankspace);
                    Console.Write(thirdPart);
                }
                if (blankspace - 2 * height - 2 > 0)
                {
                    string fourthPart = '/' + new string('.', blankspace - 2 * height - 2) + '\\';
                    Console.Write(fourthPart);
                }
                if (2 * height < blankspace - 1)
                {
                    string thirdPart = new string(' ', height);
                    Console.Write(thirdPart);
                }
                string fifthPart = "\\";
                Console.Write(fifthPart);
                string sixthPart = new string('#', (width - i - 1));
                Console.Write(sixthPart);
                Console.WriteLine();
            }
        }
    }
}