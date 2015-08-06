namespace _64BitArray
{
    using System;

    using _64BitArray.Classes;
    class StartingPoint
    {
        static void Main()
        {
            BitArray myArray = new BitArray(4294967295);
            BitArray myArray2 = new BitArray(4294967295);
            Console.WriteLine("myArray  {0}", myArray);
            Console.WriteLine("myArray2 {0}", myArray2);
            Console.WriteLine("The number                 {0}", myArray.Number);
            Console.WriteLine("myArray == myArray2        {0}", myArray == myArray2);
            Console.WriteLine("myArray != myArray2        {0}", myArray != myArray2);
            Console.WriteLine("myArray.GetHashCode()      {0}", myArray.GetHashCode());
            Console.WriteLine("myArray2.GetHashCode()     {0}", myArray2.GetHashCode());
            Console.WriteLine("Index implemented as it is in binary numbers");
            Console.WriteLine("myArray[0]                 {0}", myArray[0]);
            Console.WriteLine("myArray[31]                {0}", myArray[31]);
            Console.WriteLine("myArray[32]                {0}", myArray[32]);
            Console.Write("Foreach  ");
            foreach (var ch in myArray)
            {
                Console.Write("|{0}|",ch);                
            }
            Console.WriteLine();
        }
    }
}
