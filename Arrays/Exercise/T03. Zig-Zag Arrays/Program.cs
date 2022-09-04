using System;
using System.Linq;

namespace T03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] arrNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                //int n1 = int.Parse(Console.ReadLine());
                //int n2 = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    if (i % 2 == 0)
                    {
                        arr1[i] = arrNumbers[0];
                        arr2[i] = arrNumbers[1];
                    }
                }
                else
                {
                    if (i % 2 == 1)
                    {
                        arr1[i] = arrNumbers[1];
                        arr2[i] = arrNumbers[0];
                    }
                }
            }
            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));
        }
    }
}
