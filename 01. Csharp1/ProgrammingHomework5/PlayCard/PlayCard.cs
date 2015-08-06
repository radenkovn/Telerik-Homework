//PROBLEM 3

using System;


class PlayCard
{
    static void Main()
    {
        string possibleCard = Console.ReadLine();
        switch (possibleCard)
        {
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "10":
            case "J":
            case "Q":
            case "K":
            case "A":
                {
                    Console.WriteLine("yes");
                    break;
                }
            default:
                {
                    Console.WriteLine("no");
                    break;
                }
        }
    }
}

