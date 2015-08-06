//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

using System;
using System.Text;
class Brackets
{
    static void Main()
    {
        Console.Write("Enter your text: ");
        string input = Console.ReadLine();
        bool correct = CheckBrackets(input);
        Console.WriteLine(correct);
    }

    static bool CheckBrackets(string input)
    {
        StringBuilder builder = new StringBuilder(input);
        int leftcounter = 0;
        int rightcounter = 0;
        for (int i = 0; i < builder.Length; i++)
        {
            if (builder[i] == '(')
            {
                leftcounter++;
                builder.Remove(i, 1);
                for (int j = i; j < builder.Length; j++)
                {
                    if (builder[j] == ')')
                    {
                        builder.Remove(j, 1);
                        rightcounter++;
                        break;
                    }
                }
                i = -1;
            }
        }
        for (int i = 0; i < builder.Length; i++)
        {
            if (builder[i] == ')')
            {
                return false;
            }
        }
        if (leftcounter == rightcounter)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

