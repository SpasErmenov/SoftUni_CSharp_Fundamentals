using System;

namespace SoftUni_Arrays_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] peopleInWagon = new int[n];

            for (int i = 0; i < n; i++)
            {
                peopleInWagon[i] = int.Parse(Console.ReadLine());
                sum += peopleInWagon[i];
            }
            Console.WriteLine(string.Join(" ", peopleInWagon));
            Console.WriteLine(sum);
        }
    }
}
