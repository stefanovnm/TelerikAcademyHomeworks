namespace _05._64BitArray
{
    using System;
    using System.Collections;
    using System.Collections;
    using System.Collections.Generic;

    public class _64BitArray : IEnumerable<int> //class cannot start with number!
    {
        private const int Length = 64;
        private int[] bits = new int[Length];

        public  _64BitArray(ulong number)
        {
            string binary = DecToBin(number);
            this.bits = BitsToArray(binary);
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index> Length-1)
                {
                    throw new ArgumentOutOfRangeException("Index should be in range from 0 to 63!");
                }

                return this.bits[index];
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public static bool operator == (_64BitArray first, _64BitArray second)
        {
            return first.Equals(second);
        }  

        public static bool operator !=(_64BitArray first, _64BitArray second)
        {
            return !first.Equals(second);
        }

        public override bool Equals(object obj)
        {
            var secondObject = obj as _64BitArray;

            if (obj == null)
            {
                return false;
            }

            for (int i = 0; i < Length; i++)
            {
                if (!secondObject[i].Equals(this[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            return this.bits.GetHashCode();
        }

        public override string ToString()
        {
            return string.Join("",this.bits);
        }

        private string DecToBin(ulong number)
        {
            ulong sysBase = 2;
            ulong reminder;
            string binary = "";

            while (number>0)
            {
                reminder = number % sysBase;
                number = number / sysBase;
                binary = reminder.ToString() + binary;
            }

            return binary.ToString().PadLeft(64, '0');
        }

        private int[] BitsToArray(string binary)
        {
            int[] bitArray = new int[Length];

            for (int i = 0; i < Length; i++)
            {
                bitArray[i] = int.Parse(binary[i].ToString());
            }

            return bitArray;
        }
    }
}
