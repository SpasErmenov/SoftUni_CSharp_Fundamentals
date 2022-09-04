using System;
using System.Linq;

namespace T02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rotationCount = int.Parse(Console.ReadLine());
            int rotationCountReduced = rotationCount % arr.Length;


            for (int rot = 1; rot <= rotationCountReduced; rot++)
            {
                int firstEl = arr[0];

                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[arr.Length - 1] = firstEl;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
