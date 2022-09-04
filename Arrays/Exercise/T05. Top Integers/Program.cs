using System;
using System.Linq;

namespace T05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int lastEl = arr[arr.Length - 1];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr [i + 1])
                {
                    Console.Write($"{arr[i]} ");
                }
            }
            Console.WriteLine(lastEl);
        }
    }
}
