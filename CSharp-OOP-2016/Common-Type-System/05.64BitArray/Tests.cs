namespace _05._64BitArray
{
    using System;

    public class Tests
    {
        public static void Main()
        {
            ulong firstNumber = 18446744073709551614;
            _64BitArray firstArray = new _64BitArray(firstNumber);


            Console.WriteLine("First\ndecimal: "+ firstNumber + "\n=>\nbinary: " + firstArray);

            Console.WriteLine("\nLast bit is: "+firstArray[63]);

            ulong upperLimit = 18446744073709551615;
            _64BitArray secondArray = new _64BitArray(upperLimit);
            Console.WriteLine("\nSecond\ndecimal: " + upperLimit + "\n=>\nbinary: " + secondArray);

            ulong thirdNumber = 18446744073709551614;
            _64BitArray thirdArray = new _64BitArray(thirdNumber);
            Console.WriteLine("\nThird\ndecimal: " + thirdNumber + "\n=>\nbinary: " + thirdArray);

            Console.WriteLine("Is first equal second: "+ firstArray.Equals(secondArray));
            Console.WriteLine("Is first equal third : " + firstArray.Equals(thirdArray));
        }
    }
}
