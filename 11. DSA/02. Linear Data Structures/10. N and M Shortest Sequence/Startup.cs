namespace _10.N_and_M_Shortest_Sequence
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Startup
    {
        public static void Main()
        {
            var n = 5;
            var m = 5000;

            var sequence = new Stack<int>();
            sequence.Push(m);
            while (m > n)
            {
                if (m % 2 == 0)
                {
                    if (m / 2 >= n)
                    {
                        m = m / 2;
                        sequence.Push(m);
                        continue;
                    }
                }
                else if (m - 1 >= n)
                {
                    if ((m - 1) / 2 >= n)
                    {
                        m = m - 1;
                        sequence.Push(m);
                        continue;
                    }
                }
                if (m - 2 >= n)
                {
                    m = m - 2;
                    sequence.Push(m);
                }
                else if (m - 1 >= n)
                {
                    m = m - 1;
                    sequence.Push(m);
                }
            }

            Console.WriteLine(string.Join("=>",sequence));
        }
    }
}
