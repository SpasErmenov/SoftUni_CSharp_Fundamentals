using System;

namespace T06_Strong_number
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

                long currDigFactorial = 1;
                for (int r = currDigit; r > 1; r--)
                {
                    currDigFactorial *= r;
                }

                factorialSum += currDigFactorial; 
            }

            if (factorialSum == int.Parse(number))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            
        }
    }
}
