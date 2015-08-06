//Using delegates write a class Timer that can execute certain method at each t seconds.

namespace _07.Timer
{
    using System;
    using _07.Timer.Classes;
    class Program
    {
        static void Main()
        {
            //I only did it with a void function which takes a string as an arguement. change the last digit to the number of seconds you want the interval to be
            DelegateTimer.Timer(Console.WriteLine, "Hello", 2);
        }
    }
}
