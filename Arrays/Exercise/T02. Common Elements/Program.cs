using System;

namespace T02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split();
            string[] array2 = Console.ReadLine().Split();
            string[] arrayResult = new string[array1.Length];
            string[] arrayFinalResul = new string[arrayResult.Length];
            int step = -1;
            int step2 = -1;

            for (int i = 0; i < array1.Length ; i++)
            {
                for (int j = 0; j < array2.Length ; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        step++;
                        arrayResult[step] = array1[i];
                    }
                }
            }
            for (int m = 0; m < arrayResult.Length; m++)
            {
                if (arrayResult[m] != null)
                {
                    step2++;
                    arrayFinalResul[step2] = arrayResult[m];
                }
            }
            Console.WriteLine(string.Join(" ", arrayFinalResul));
        }
    }
}
