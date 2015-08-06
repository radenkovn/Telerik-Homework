using System;
using System.IO;
class MaxAreaSum
{
    static void Main()
    {
        StreamReader reader = new StreamReader("..\\..\\TextInput.txt");
        int length = int.Parse(reader.ReadLine());
        var matrix = new int[length, length];
        using (reader)
        {
            for (int j = 0; j < length; j++)
            {
                string currentLine = reader.ReadLine();
                string[] line = currentLine.Split(' ');
                for (int i = 0; i < length; i++)
                {
                    matrix[j, i] = int.Parse(line[i]);
                }
            }
        }
        int sum = int.MinValue;
        for (int i = 0; i < length - 1; i++)
        {
            for (int j = 0; j < length - 1; j++)
            {
                int localsum = matrix[j, i] + matrix[j, i + 1] + matrix[j + 1, i] + matrix[j + 1, i + 1];
                if (sum < localsum)
                {
                    sum = localsum;
                }
            }
        }
        Console.WriteLine("The maximum sum of the elements is {0}",sum);
    }
}

