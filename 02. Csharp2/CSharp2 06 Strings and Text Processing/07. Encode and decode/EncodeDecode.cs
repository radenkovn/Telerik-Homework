//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.


using System;
using System.Text;
class EncodeDecode
{
    static void Main()
    {
        Console.Write("Enter your text: ");
        string input = Console.ReadLine();
        Console.Write("Enter your cipher: ");
        string cipher = Console.ReadLine();
        string result = Encode(input, cipher);
        Console.WriteLine("The result is {0}", result);
    }

    private static string Encode(string input, string cipher)
    {
        StringBuilder result = new StringBuilder();
        StringBuilder first = new StringBuilder(input);
        StringBuilder second = new StringBuilder(cipher);
        int length = (Math.Max(input.Length, cipher.Length));
        first.Append(input, 0, length - input.Length);
        second.Append(cipher, 0, length - cipher.Length);
        for (int i = 0; i < length; i++)
        {
            result.Append(first[i] ^ second[i]);
        }
        return result.ToString();
    }

}

