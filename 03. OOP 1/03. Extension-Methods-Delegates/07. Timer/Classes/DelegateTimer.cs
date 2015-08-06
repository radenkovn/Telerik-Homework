namespace _07.Timer.Classes
{
    using System;
    using System.Timers;
    public static class DelegateTimer
    {
        public static void Timer(Action<string> action, string input, double time)
        {
            var timer1 = new Timer(time * 1000);// 1000 ms is one second
            ElapsedEventHandler handler = (s, e) =>
            {
                action(input);
            };
            timer1.Elapsed += handler;
            timer1.Enabled = true;
            Console.CursorVisible = false;
            Console.WriteLine("Press the Enter key to exit the program.");
            Console.ReadLine();
        }
    }
}
