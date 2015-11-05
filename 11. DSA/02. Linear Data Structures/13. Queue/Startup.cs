namespace _13.Queue
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var stack = new MyQueue<int>();
            stack.Enqueue(1);
            stack.Enqueue(2);
            stack.Enqueue(3);
            stack.Enqueue(4);
            stack.Enqueue(5);
            stack.Enqueue(6);
            stack.Enqueue(7);

            Console.WriteLine(string.Join(", ", stack));

            stack.Dequeue();
            stack.Dequeue();
            stack.Dequeue();
            stack.Dequeue();
            stack.Enqueue(7);
            stack.Dequeue();
            stack.Enqueue(7);

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
