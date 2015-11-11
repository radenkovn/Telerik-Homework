using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stools
{
    class Startup
    {
        static Stool[] stools;
        static int n;

        static int[, ,] memos;

        public struct Stool
        {
            public Stool(int x, int y, int z)
                :this()
            {
                this.X = x;
                this.Y = y;
                this.Z = z;
            }

            public int X { get; set; }

            public int Y { get; set; }

            public int Z { get; set; }
        }

        static void Main()
        {
            n = int.Parse(Console.ReadLine());
            stools = new Stool[n];
            memos = new int[(1 << n), 16, 4];
            for (int i = 0; i < n; i++)
            {
                var sides = Console.ReadLine().Split(' ');
                stools[i] = new Stool(int.Parse(sides[0]), int.Parse(sides[1]), int.Parse(sides[2]));
            }

            var max = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    max = Math.Max(max, GetMax((1 << n) - 1, i, j));
                }
            }
            Console.WriteLine(max);
        }

        public static int GetMax(int mask, int position, int side)
        {
            if (mask == (1 << position))
            {
                if (side == 0)
                {
                    return stools[position].X;
                }
                else if (side == 1)
                {
                    return stools[position].Y;
                }
                return stools[position].Z;
            }

            if (memos[mask, position, side] > 0)
            {
                return memos[mask, position, side];
            }

            var sideX = (side == 0) ? stools[position].Y : stools[position].X;
            var sideY = (side == 2) ? stools[position].Y : stools[position].Z;
            var sideH = stools[position].X + stools[position].Y + stools[position].Z - sideX - sideY;

            var maskedValues = mask ^ (1 << position);

            var result = sideH;
            for (int i = 0; i < n; i++)
            {
                if (((maskedValues >> i) & 1) == 1)
                {
                    if ((stools[i].Y >= sideX && stools[i].Z >= sideY) || (stools[i].Z >= sideX && stools[i].Y >= sideY))
                    {
                        result = Math.Max(result, GetMax(maskedValues, i, 0) + sideH);
                    }
                    if (stools[i].X == stools[i].Y && stools[i].X == stools[i].Z)
                    {
                        continue;
                    }
                    if ((stools[i].X >= sideX && stools[i].Z >= sideY) || (stools[i].Z >= sideX && stools[i].X >= sideY))
                    {
                        result = Math.Max(result, GetMax(maskedValues, i, 1) + sideH);
                    }
                    if ((stools[i].X >= sideX && stools[i].Y >= sideY) || (stools[i].Y >= sideX && stools[i].X >= sideY))
                    {
                        result = Math.Max(result, GetMax(maskedValues, i, 2) + sideH);
                    }
                }
            }

            memos[mask, position, side] = result;
            return result;
        }
    }
}
