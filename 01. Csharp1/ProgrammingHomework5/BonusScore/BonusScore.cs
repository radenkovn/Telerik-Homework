//PROBLEM 2

using System;


class BonusScore
{
    static void Main()
    {
        int score = int.Parse(Console.ReadLine());
        if (score < 1 || score > 9)
        {
            Console.WriteLine("invalid score");
        }
        else if (1 <= score && score <= 3)
        {
            score *= 10;
            Console.WriteLine(score);
        }
        else if (3 <= score && score <= 6)
        {
            score *= 100;
            Console.WriteLine(score);
        }
        else if (7 <= score && score <= 9)
        {
            score *= 1000;
            Console.WriteLine(score);
        }
    }
}

