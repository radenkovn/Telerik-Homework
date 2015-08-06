namespace _64BitArray.Classes
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    class BitArray : IEnumerable
    {
        private char[] myArray = new char[64];
        private ulong number;
        public BitArray(ulong number)
        {
            this.Number = number;
            myArray = new char[64];
            char[] numberToChar = this.DecimalToBinary(number);
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = '0';
            }
            int counter = myArray.Length-1;
            for (int i = numberToChar.Length - 1; i >= 0; i--)
            {
                myArray[counter] = numberToChar[i];
                counter--;
            }
        }
        public ulong Number { get { return this.number; } private set { this.number = value; } }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public IEnumerator GetEnumerator()
        {
            foreach (var ch in myArray)
            {
                yield return ch;
            }
        }
        public static bool operator ==(BitArray arr1, BitArray arr2)
        {
            if (arr1.ToString() == arr2.ToString())
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(BitArray arr1, BitArray arr2)
        {
            if (arr1.ToString() == arr2.ToString())
            {
                return false;
            }
            return true;
        }
        public int this[int index]
        {
            get
            {
                if (this.myArray[myArray.Length-1-index] == '1')
                {
                    return 1;
                }
                else return 0;
            }
            set
            {
                if (value == 1)
                {
                    this.myArray[myArray.Length - 1 - index] = '1';
                }
                else this.myArray[myArray.Length - 1 - index] = '0';
            }
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < myArray.Length; i++)
            {
                result.Append(myArray[i]);
            }
            return result.ToString();
        }
        private char[] DecimalToBinary(ulong number)
        {
            string reversed = "";
            int digit;
            int counter = 0;
            ulong changer = number;
            while (changer > 0)
            {
                counter++;
                changer /= 2;
            }

            changer = number;
            for (int i = 0; i < counter; i++)
            {
                digit = (int)(changer % 2);
                switch (digit)
                {
                    case 1: reversed += "1"; break;
                    case 0: reversed += "0"; break;
                    default: break;
                }
                changer /= 2;
            }
            char[] result = reversed.ToCharArray();
            Array.Reverse(result);
            return result;
        }
    }
}
