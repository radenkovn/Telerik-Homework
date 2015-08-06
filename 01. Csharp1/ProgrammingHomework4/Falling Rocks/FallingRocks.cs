//PROBLEM 12
//Before going any further, I have to admit that I pretty much copied 90% of the code inside
//the "Cars" application from the given examples (https://github.com/NikolayIT/CSharpConsoleGames), and
//that I saw a lot of things for the first time in my ilfe while writing this program.
//Looks like it works! Good luck, and have fun while playing!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


struct Object
{
    public int x;
    public int y;
    public string c;
    public ConsoleColor color;
}

class FallingRocks
{
    static void PrintOnPosition(int x, int y, string c,
    ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }
    static void PrintStringOnPosition(int x, int y, string str,
        ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }
    static void Main()
    {
        int score = 0;
        int playfieldWidth = 50;
        Console.BufferHeight = Console.WindowHeight = 30;
        Console.BufferWidth = Console.WindowWidth = 51;
        Object userGuy = new Object();
        userGuy.x = 24;
        userGuy.y = Console.WindowHeight - 1;
        userGuy.c = "(0)";
        userGuy.color = ConsoleColor.White;
        Random random = new Random();
        List<Object> objects = new List<Object>();
        while (true)
        {
            int chance = random.Next(0, 540);
            //   ^, @, *, &, +, %, $, #, !, ., ;, -

            if (chance <= 30)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Cyan;
                newObject.c = "^";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (30 < chance && chance <= 60)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Cyan;
                newObject.c = "@";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (60 < chance && chance <= 90)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Cyan;
                newObject.c = "*";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (90 < chance && chance <= 120)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Cyan;
                newObject.c = "&";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (120 < chance && chance <= 150)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Cyan;
                newObject.c = "+";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (150 < chance && chance <= 180)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Cyan;
                newObject.c = "%";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (180 < chance && chance <= 210)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Cyan;
                newObject.c = "$";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (210 < chance && chance <= 240)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Cyan;
                newObject.c = "#";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (240 < chance && chance <= 270)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Cyan;
                newObject.c = "!";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (270 < chance && chance <= 300)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Cyan;
                newObject.c = ".";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (300 < chance && chance <= 330)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Cyan;
                newObject.c = ";";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (330 < chance && chance <= 360)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Cyan;
                newObject.c = "-";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (360 < chance && chance <= 370)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Yellow;
                newObject.c = "^^";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (370 < chance && chance <= 380)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Yellow;
                newObject.c = "@@";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (380 < chance && chance <= 390)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Yellow;
                newObject.c = "**";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (390 < chance && chance <= 400)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Yellow;
                newObject.c = "&&";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (400 < chance && chance <= 410)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Yellow;
                newObject.c = "++";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (410 < chance && chance <= 420)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Yellow;
                newObject.c = "%%";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (420 < chance && chance <= 430)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Yellow;
                newObject.c = "$$";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (430 < chance && chance <= 440)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Yellow;
                newObject.c = "##";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (440 < chance && chance <= 450)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Yellow;
                newObject.c = "!!";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (450 < chance && chance <= 460)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Yellow;
                newObject.c = "..";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (460 < chance && chance <= 470)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Yellow;
                newObject.c = ";;";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (470 < chance && chance <= 480)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Cyan;
                newObject.c = "--";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (480 < chance && chance <= 485)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Red;
                newObject.c = "^^^";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (485 < chance && chance <= 490)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Red;
                newObject.c = "@@@";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (490 < chance && chance <= 495)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Red;
                newObject.c = "***";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (495 < chance && chance <= 500)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Red;
                newObject.c = "&&&";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (500 < chance && chance <= 505)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Red;
                newObject.c = "+++";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (505 < chance && chance <= 510)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Red;
                newObject.c = "%%%";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (510 < chance && chance <= 515)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Red;
                newObject.c = "$$$";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (515 < chance && chance <= 520)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Red;
                newObject.c = "###";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (520 < chance && chance <= 525)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Red;
                newObject.c = "!!!";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (525 < chance && chance <= 530)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Red;
                newObject.c = "...";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (530 < chance && chance <= 535)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Red;
                newObject.c = ";;;";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }
            else if (535 < chance && chance <= 540)
            {
                Object newObject = new Object();
                newObject.color = ConsoleColor.Red;
                newObject.c = "--";
                newObject.x = random.Next(0, playfieldWidth);
                newObject.y = 0;
                objects.Add(newObject);
            }

            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (userGuy.x - 1 >= 0)
                    {
                        userGuy.x = userGuy.x - 1;
                    }

                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (playfieldWidth > userGuy.x +2)
                    {
                        userGuy.x = userGuy.x + 1;
                    }
                }
            }
            List<Object> newList = new List<Object>();
            for (int i = 0; i < objects.Count; i++)
            {
                Object oldObject = objects[i];
                Object newObject = new Object();
                newObject.x = oldObject.x;
                newObject.y = oldObject.y + 1;
                newObject.c = oldObject.c;
                newObject.color = oldObject.color;
                bool singleC = ((newObject.c == "^") || (newObject.c == "@") || (newObject.c == "*") || (newObject.c == "&") || (newObject.c == "+") || (newObject.c == "%") || (newObject.c == "$") || (newObject.c == "#") || (newObject.c == "!") || (newObject.c == ".") || (newObject.c == ";") || (newObject.c == "-"));
                bool doubleC = ((newObject.c == "^^") || (newObject.c == "@@") || (newObject.c == "**") || (newObject.c == "&&") || (newObject.c == "++") || (newObject.c == "%%") || (newObject.c == "$$") || (newObject.c == "##") || (newObject.c == "!!") || (newObject.c == "..") || (newObject.c == ";;") || (newObject.c == "--"));
                bool trippleC = ((newObject.c == "^^^") || (newObject.c == "@@@") || (newObject.c == "***") || (newObject.c == "&&&") || (newObject.c == "+++") || (newObject.c == "%%%") || (newObject.c == "$$$") || (newObject.c == "###") || (newObject.c == "!!!") || (newObject.c == "...") || (newObject.c == ";;;") || (newObject.c == "---"));
                if (singleC && newObject.y == userGuy.y && (newObject.x == userGuy.x || newObject.x == userGuy.x + 1 || newObject.x == userGuy.x + 2))
                {
                    PrintStringOnPosition(20, 14, "GAME OVER!!!", ConsoleColor.Red);
                    PrintStringOnPosition(16, 16, "Press [enter] to exit", ConsoleColor.Red);
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                if (doubleC && newObject.y == userGuy.y && (newObject.x == userGuy.x || newObject.x == userGuy.x + 1 || newObject.x == userGuy.x + 2 || newObject.x + 1 == userGuy.x))
                {
                    PrintStringOnPosition(20, 14, "GAME OVER!!!", ConsoleColor.Red);
                    PrintStringOnPosition(16, 16, "Press [enter] to exit", ConsoleColor.Red);
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                if (trippleC && newObject.y == userGuy.y && (newObject.x == userGuy.x || newObject.x == userGuy.x + 1 || newObject.x == userGuy.x + 2 || newObject.x + 1 == userGuy.x || newObject.x + 2 == userGuy.x))
                {
                    PrintStringOnPosition(20, 14, "GAME OVER!!!", ConsoleColor.Red);
                    PrintStringOnPosition(16, 16, "Press [enter] to exit", ConsoleColor.Red);
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                if (newObject.y < Console.WindowHeight)
                {
                    newList.Add(newObject);
                }
            }
            PrintStringOnPosition(0, 0, "GAME OVER!!!", ConsoleColor.Green);
            objects = newList;
            Console.Clear();
            PrintOnPosition(userGuy.x, userGuy.y, userGuy.c, userGuy.color);
            foreach (Object randomObject in objects)
            {
                score++;
                PrintOnPosition(randomObject.x, randomObject.y, randomObject.c, randomObject.color);
                PrintStringOnPosition(0, 0, "SCORE: ", ConsoleColor.Green);
                PrintStringOnPosition(10, 0, Convert.ToString(score), ConsoleColor.Green);
            }
            Thread.Sleep((int)(150));
        }
    }
}

