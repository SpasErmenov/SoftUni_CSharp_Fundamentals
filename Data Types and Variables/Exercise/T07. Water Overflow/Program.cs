using System;

namespace T07_Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            const int tankCapacity = 255;
            int waterInTank = 0;

            for (int i = 0; i < n; i++)
            {
                int litters = int.Parse(Console.ReadLine());
                waterInTank += litters;
                if (waterInTank > tankCapacity)
                {
                    waterInTank -= litters;
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(waterInTank);
        }
    }
}
