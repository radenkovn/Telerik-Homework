namespace Fibonacci
{
    using System;

    public class Startup
    {
        public class Matrix
        {
            private const int Mod = 1000000007;

            public Matrix(long a, long b, long c)
            {
                this.A = a;
                this.B = b;
                this.C = c;
            }

            public Matrix(Matrix first, Matrix second)
            {
                this.A = first.A * second.A + first.B * second.B;
                this.B = first.A * second.B + first.B * second.C;
                this.C = first.B * second.B + first.C * second.C;

                this.A = this.A % Mod;
                this.B = this.B % Mod;
                this.C = this.C % Mod;
            }

            public long A { get; set; }

            public long B { get; set; }

            public long C { get; set; }
        }

        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(PowMatrix(new Matrix(1, 1, 0), n).B);
        }

        public static Matrix PowMatrix(Matrix a, long p)
        {
            if (p == 1)
            {
                return a;
            }

            if (p % 2 == 1)
            {
                return new Matrix(PowMatrix(a, p - 1), a);
            }
            a = PowMatrix(a, p / 2);
            return new Matrix(a, a);
        }
    }
}
