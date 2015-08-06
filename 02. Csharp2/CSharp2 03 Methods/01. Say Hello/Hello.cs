﻿
//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.

//  input 	output
//  Peter 	Hello, Peter!

using System;

class Hello
{
    static void Main()
    {
        SayHello();
    }

    static void SayHello()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", name);
    }
}

