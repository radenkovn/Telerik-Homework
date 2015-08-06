namespace MatrixTest
{
    using System;
    using System.Collections.Generic;
    class MatrTest
    {
        static void Main()
        {
            //If you want to test addition and subtraction, you have to make matrixes of the same size

            var myMatr1 = new Matrix<int>(5, 3);
            var myMatr2 = new Matrix<int>(3, 2);
            
            for (int i = 0; i < myMatr1.Rows; i++)
            {
                for (int j = 0; j < myMatr1.Cols; j++)
                {
                    myMatr1[i, j] = 2;
                }
            }
            for (int i = 0; i < myMatr2.Rows; i++)
            {
                for (int j = 0; j < myMatr2.Cols; j++)
                {
                    myMatr2[i, j] = 5;
                }
            }
            Console.WriteLine("Before adding a zero element:\n");
            if (myMatr1)
            {
                Console.WriteLine("Contains a zero element");
            }
            else
            {
                Console.WriteLine("Does not contain a zero element");
            }
            myMatr1[0, 0] = 0;
            Console.WriteLine("\nAfter adding a zero element:\n");
            if (myMatr1)
            {
                Console.WriteLine("Contains a zero element");
            }
            else
            {
                Console.WriteLine("Does not contain a zero element");
            }
            Console.WriteLine("\nMultiplication:");
            Console.WriteLine(myMatr1 * myMatr2);
            
        }
    }
    
    public class Matrix<T>
    {
        private T[,] matrix;
        private int cols;
        private int rows;
        public int Cols { get { return this.cols; } }
        public int Rows { get { return this.rows; } }
        public T this[int row, int col] { get { return this.matrix[row, col]; } set { this.matrix[row, col] = value; } }
        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.matrix = new T[this.rows, this.cols];
        }

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Rows != m2.Rows)
            {
                throw new ArgumentOutOfRangeException("The rows of the both matrixes should have the same value");
            }
            if (m1.Cols != m2.Cols)
            {
                throw new ArgumentOutOfRangeException("The cols of the both matrixes should  have the same value");
            }
            Matrix<T> resultM = new Matrix<T>(m1.Rows, m1.Cols);
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Cols; j++)
                {

                    resultM[i, j] = (dynamic)m1[i, j] + (dynamic)m2[i, j];
                }
            }
            return resultM;
        }
        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Rows != m2.Rows)
            {
                throw new ArgumentOutOfRangeException("The rows of the both matrixes should have the same value");
            }
            if (m1.Cols != m2.Cols)
            {
                throw new ArgumentOutOfRangeException("The cols of the both matrixes should  have the same value");
            }
            Matrix<T> resultM = new Matrix<T>(m1.Rows, m1.Cols);
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Cols; j++)
                {

                    resultM[i, j] = (dynamic)m1[i, j] - (dynamic)m2[i, j];
                }
            }
            return resultM;
        }
        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Cols != m2.Rows)
            {
                throw new ArgumentOutOfRangeException("The rows of the both matrixes should have the same value");
            }

            Matrix<T> resultM = new Matrix<T>(m1.Rows, m2.Cols);
            for (int resultRow = 0; resultRow < m1.Rows; resultRow++)
            {
                for (int resultCol = 0; resultCol < m2.Cols; resultCol++)
                {
                    for (int i = 0; i < m1.Cols; i++)
                    {
                        resultM[resultRow, resultCol] = resultM[resultRow, resultCol] + (dynamic)m1[resultRow, i] * (dynamic)m2[i, resultCol];
                    }
                    
                }    
            }
            return resultM;
        }
        public static bool operator true(Matrix<T> m1)
        {
            for (int row = 0; row < m1.Rows; row++)
            {
                for (int col = 0; col < m1.Cols; col++)
                {
                    if (m1[row, col].Equals(0))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool operator false(Matrix<T> m1)
        {
            for (int row = 0; row < m1.Rows; row++)
            {
                for (int col = 0; col < m1.Cols; col++)
                {
                    if (m1[row, col].Equals(0))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        
        public override string ToString()
        {
            Console.WriteLine("The Marix");
            Console.WriteLine();
            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Cols; col++)
                {
                    Console.Write("{0,3} ", this[row, col]);
                }
                Console.WriteLine();
            }
            return string.Empty;

        }
    }
}
