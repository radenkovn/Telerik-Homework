namespace _01.Priority_Queue
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var queue = new MyPriorityQueue<int>();
            queue.Insert(10);
            queue.Insert(5);
            queue.Insert(7);
            queue.Insert(3);
            queue.Insert(15);
            queue.Insert(4);
            queue.Insert(13);
            queue.Insert(20);
            queue.Insert(5);
            queue.Insert(500);
            queue.Insert(12);
            queue.Insert(145);
            queue.Insert(10);
            queue.Insert(5123);
            queue.Insert(2);
            queue.Insert(513);
            queue.Insert(-20);
            queue.Insert(-20);
            queue.Insert(-20);
            queue.Insert(-20);
            queue.Insert(-20);
            queue.Insert(400);


            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("Max: {0}", queue.ExtractMax());
            Console.WriteLine("-----------");
            Console.WriteLine();

            while (queue.Count > 0)
            {
                Console.WriteLine("Max: {0}", queue.ExtractMax());
            }
        }
    }
}
