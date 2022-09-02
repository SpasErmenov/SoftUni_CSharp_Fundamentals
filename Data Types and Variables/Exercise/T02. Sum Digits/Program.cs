using System;

namespace T02_Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            long factorialSum = 0;

            for (int i = 0; i <= number.Length - 1; i++)
            {
                char currCh = number[i];
                int currDigit = (int)currCh - 48;

                factorialSum += currDigit;
            }

            Console.WriteLine(factorialSum);

        }
    }
}
