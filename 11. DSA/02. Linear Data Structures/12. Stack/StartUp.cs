namespace _12.Stack
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);

            Console.WriteLine(string.Join(", ", stack));

            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Push(7);


            Console.WriteLine(string.Join(", ", stack));

        }
    }
}
